using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace BigBoys.Lua
{
    public readonly struct ReadLuaObj
    {
        private readonly object[] _regs;
        private readonly object[] _K;
        private readonly Table _G;
        private readonly uint[] _ops;

        private object RGet(int i) => _regs[i];
        private void RSet(int i, object v) => _regs[i] = v;
        private object KGet(int i) => _K[i];
        private object RKGet(int i) => i > 0xFF ? KGet(i & 0xFF) : RGet(i);
        private object GGet(object k)
        {
            if (k is string key)
            {
                if (_G.Contains(key))
                {
                    return _G[key];
                }
                return Globals.Lookup[key];
            }
            throw new InvalidOperationException($"Trying to lookup non string key: {k}");
        }
        private void GSet(object k, object v) => _G[k] = v;

        private static float F8(uint v)
        {
            var x = v & 0b111u;
            var e = v >> 3;
            return e == 0 ? x : (float)((x | 8) * Math.Pow(2, e - 1));
        }

        private void Exec()
        {
            for(var pc = 0; pc < _ops.Length; pc++)
            {
                var code = _ops[pc];
                var op = code & 0b111111;
                var a = (int)((code >> 6) & 0b11111111u);
                var c = (int)((code >> 14) & 0b111111111u);
                var b = (int)((code >> 23) & 0b111111111u);
                var bx = (int)((code >> 14) & 0b111111111111111111u);
                var sbx = bx - 131071;
                switch(op)
                {
                    case 0: // MOVE
                        RSet(a, RGet(b));
                        break;
                    case 1: // LOADK
                        RSet(a, KGet(bx));
                        break;
                    case 2: // LOADBOOL
                        RSet(a, b != 0);
                        if (c != 0)
                        {
                            pc++;
                        }
                        break;
                    case 3: // LOADNIL
                        for (var r = a; a <= b; r++)
                        {
                            RSet(r, null);
                        }
                        break;
                    case 5: // GETGLOBAL
                        RSet(a, GGet(KGet(bx)));
                        break;
                    case 6: // GETTABLE
                        RSet(a, (RGet(b) as Table)[RGet(c)]);
                        break;
                    case 7: // SETGLOBAL
                        GSet(KGet(bx), RGet(a));
                        break;
                    case 9: // SETTABLE
                        (RGet(a) as Table)[RKGet(b)] = RKGet(c);
                        break;
                    case 10: // NEWTABLE
                        RSet(a, new Table());
                        break;
                    case 28: // CALL
                        break;
                    case 30: // RETURN
                        break;
                    case 34: // SETLIST
                        {
                            var table = RGet(a) as Table;
                            for(var i = 1; i <= b; i++)
                            {
                                table[(c - 1) * 50 + i] = RGet(a + i);
                            }
                        }
                        break;
                    case 36: // CLOSURE
                        RSet(a, "<CLOSURE>");
                        pc++;
                        break;
                    default:
                        throw new InvalidOperationException($"Invalid OP: {op}");
                }
            }
        }

        private ReadLuaObj(Stream stream)
        {
            using (var reader = new BinaryReader(stream, Encoding.UTF8))
            {
                var magic = reader.ReadBytes(12);
                if (magic.Equals(new byte[] { 0x1B, 0x4C, 0x75, 0x61, 0x51, 0x00, 0x01, 0x04, 0x04, 0x04, 0x08, 0x00 }))
                {
                    throw new InvalidDataException("Magic doesn't match!");
                }
                var sourceLength = reader.ReadInt32();
                var source = reader.ReadBytes(sourceLength);
                var flags = reader.ReadBytes(12);
                var opCount = reader.ReadInt32();
                var ops = new uint[opCount];
                for (var i = 0; i < opCount; i++)
                {
                    ops[i] = reader.ReadUInt32();
                }
                var constCount = reader.ReadInt32();
                var consts = new object[constCount];
                for (var i = 0; i < constCount; i++)
                {
                    var type = reader.ReadByte();
                    switch (type)
                    {
                        case 0:
                            consts[i] = null;
                            break;
                        case 1:
                            consts[i] = reader.ReadByte() != 0;
                            break;
                        case 2:
                            throw new InvalidDataException("Functions not suported!");
                        case 3:
                            consts[i] = (float)reader.ReadDouble();
                            break;
                        case 4:
                            {
                                var size = reader.ReadInt32();
                                if (size == 0)
                                {
                                    consts[i] = "";
                                }
                                else
                                {
                                    consts[i] = Encoding.UTF8.GetString(reader.ReadBytes(size).Take(size - 1).ToArray());
                                }
                                break;
                            }
                        default:
                            throw new InvalidDataException($"Unknown const type {type}");
                    }
                }
                _regs = new object[256];
                _K = consts;
                _G = new Table();
                _ops = ops;
            }
        }

        public static Table FromStream(Stream stream)
        {
            var ctx = new ReadLuaObj(stream);
            ctx.Exec();
            return ctx._G;
        }
    }
}
