using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using BigBoys.Context;
using BigBoys.Helpers;
using BigBoys.Lua;
using BigBoys.Enums;

namespace BigBoys.Execution
{
    public readonly struct Params
    {
        public Table PassThrough { get; }
        public Table PerBlock { get; }
        public IReadOnlyList<BBBlock> SubBlocks { get; }
        public int LastResult { get; }

        public Params(Table passThrough, Table perBlock, IReadOnlyList<BBBlock> subBlocks, int lastResult)
        {
            PassThrough = passThrough;
            PerBlock = perBlock;
            SubBlocks = subBlocks;
            LastResult = lastResult;
        }

        public int Exec(IContext c)
        {
            var lastResult = 0;
            foreach (BBBlock block in SubBlocks)
            {
                lastResult = block.Function.Call(c, new Params(PassThrough, PerBlock, block.SubBlocks, lastResult));
            }
            return 0;
        }

        public object GetBBParam(string key)
        {
            if (PerBlock[$"{key}Var"] is string varName)
            {
                var varTable = PassThrough;
                if (PerBlock[$"{key}VarTable"] is string tableName)
                {
                    if (PassThrough[tableName] is Table table)
                    {
                        varTable = table;
                    }
                }
                var varValue = varTable[varName];
                if (varValue != null)
                {
                    return varValue;
                }
            }
            return PassThrough[key] ?? PerBlock[key];
        }

        public void GetBBParam(out bool result, string key, bool require = false, bool @default = default)
        {
            result = GetBBParam(key).AsBool() ?? (!require ? @default : throw new ArgumentNullException(key));
        }

        public void GetBBParam(out int result, string key, bool require = false, int @default = default)
        {
            result = GetBBParam(key).AsInt() ?? (!require ? @default : throw new ArgumentNullException(key));
        }

        public void GetBBParam(out string result, string key, bool require = false, string @default = default)
        {
            result = GetBBParam(key).AsString() ?? (!require ? @default : throw new ArgumentNullException(key));
        }

        public void GetBBParam(out IUnit result, string key, bool require = false, IUnit @default = default)
        {
            var value = GetInVarOrPass($"{key}Var", key);
            result = value.AsUnit() ?? (!require ? @default : throw new ArgumentNullException(key));
        }

        public void GetBBParam<T>(out T result, string key, bool require = false, T @default = default) where T : struct, Enum
        {
            result = GetBBParam(key).AsEnum<T>() ?? (!require ? @default : throw new ArgumentNullException(key));
        }

        public void GetBBParam(out Vector3 result, string key, bool require = false, Vector3 @default = default)
        {
            result = GetBBParam(key).AsVector3() ?? (!require ? @default : throw new ArgumentNullException(key));
        }

        public void GetBBParam(out GObjID result, string key, bool require = false, GObjID @default = default)
        {
            var value = GetInVarOrPass($"{key}Var", key);
            result = value.AsUnit()?.GObjID ?? (!require ? @default : throw new ArgumentNullException(key));
        }

        public void GetBBParam(out TeamID result, string key, bool require = false, TeamID @default = default)
        {
            var value = GetBBParam(key);
            if (value is TeamIDObj teamIDObj)
            {
                string objKey;
                switch(teamIDObj)
                {
                    case TeamIDObj.TEAM_CASTER:
                        objKey = "Caster";
                        break;
                    case TeamIDObj.TEAM_OWNER:
                        objKey = "Owner";
                        break;
                    case TeamIDObj.TEAM_TARGET:
                        objKey = "Target";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(key);
                }
                GetBBParam(out IUnit unit, objKey, require);
                result = unit?.TeamID ?? (!require ? @default : throw new ArgumentNullException(key));
            }
            else
            {
                result = value.AsEnum<TeamID>() ?? (!require ? @default : throw new ArgumentNullException(key));
            }
        }

        public void GetBBParam(out SpellFlagsType result, string key, bool require = false, SpellFlagsType @default = default)
        {
            result = GetBBParam(key).AsSpellFlagsType() ?? (!require ? @default : throw new ArgumentNullException(key));
            if ((result & SpellFlagsType.AffectsAllSides) == 0)
            {
                result |= SpellFlagsType.AffectsAllSides;
            }
            if ((result & (SpellFlagsType.AffectsAllUnitTypes | SpellFlagsType.AffectBuildings)) == 0)
            {
                result |= SpellFlagsType.AffectBuildings;
            }
        }

        public void GetBBParam(out SpellSlot result, string key, bool require = false, SpellSlot @default = default)
        {
            GetBBParam(out SlotsType type, $"{key}Type", require, @default.Type);
            GetBBParam(out int number, $"{key}Number", require, @default.Number);
            GetBBParam(out SpellbookType book, $"{key}Book", false, @default.Book);
            result = new SpellSlot(type, number, book);
        }

        public void GetBBParam(out float result, string key, bool require = false, float @default = default)
        {
            result = GetInBlock(key).AsFloat() ?? @default;
            if (GetInBlock($"{key}ByLevel") is Table byLevelTable)
            {
                int level = GetInPass("Level").AsInt() ?? (!require ? 0 : throw new ArgumentNullException(key));
                result += byLevelTable[level].AsFloat() ?? (!require ? @default : throw new ArgumentNullException(key));
            }
            if (GetInBlock($"{key}Var") is string)
            {
                result += GetInVarTable($"{key}VarTable", $"{key}Var").AsFloat() ?? (!require ? @default : throw new ArgumentNullException(key));
            }
            result *= GetInPass($"{key}Multiplier").AsFloat() ?? 1.0f;
        }

        public void SetBBParam(string key, object value)
        {
            if (GetInBlock($"{key}Var") is string @var)
            {
                GetTable($"{key}VarTable")[@var] = value;
            }
        }

        public object GetInBlock(string block)
        {
            return PerBlock[block];
        }

        public object GetInPass(string pass)
        {
            return PassThrough[pass];
        }

        public object GetInVar(string @var)
        {
            if (PerBlock[@var] is string key)
            {
                return PassThrough[key];
            }
            return null;
        }

        public object GetInByLevel(string bylevel)
        {
            if (GetInPass("Level").AsInt() is int level && GetInBlock(bylevel).AsTable() is Table table)
            {
                return table[level];
            }
            return null;
        }

        public object GetInVarOrPass(string @var, string pass)
        {
            return GetInVar(@var) ?? GetInPass(pass);
        }

        public object GetInVarTable(string tableVar, string @var, bool create = false)
        {
            if (PerBlock[@var] is string key)
            {
                return GetTable(tableVar, @create)[key];
            }
            return null;
        }

        public object GetInVarTableOrBlock(string tableVar, string @var, string block, bool create = false)
        {
            return GetInVarTable(tableVar, @var, create) ?? GetInBlock(block);
        }

        public object GetInVarTableOrPassOrBlock(string tableVar, string @var, string block, bool create = false)
        {
            return GetInVarTable(tableVar, @var, create) ?? GetInPass(block) ?? GetInBlock(block);
        }

        public void SetInVarTable(string tableVar, string @var, object value, bool create = false)
        {
            GetTable(tableVar, create)[GetInVar(@var).AsString().Require()] = value;
        }

        private Table GetTable(string tableVar, bool create = false)
        {
            Table table = null;
            if (PerBlock[tableVar] is string tableKey)
            {
                table = PassThrough[tableKey] as Table;
                if (table == null && create)
                {
                    table = new Table();
                    PassThrough[tableKey] = table;
                    return table;
                }
            }
            return table ?? PassThrough;
        }
    }
}
