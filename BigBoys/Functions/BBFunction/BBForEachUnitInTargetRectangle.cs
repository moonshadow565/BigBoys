﻿using System;
using System.Numerics;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBFunction
    {
        public sealed class BBForEachUnitInTargetRectangle : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string iterator, "IteratorVar", @default: "Owner");
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float halfWidth, "HalfWidthg", require: true);
                p.GetBBParam(out float halfLength, "HalfLength", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                var result = c.BBForEachUnitInTargetRectangle(
                    attacker: attacker,
                    center: center,
                    halfWidth: halfWidth,
                    halfLength: halfLength,
                    flags: flags,
                    buffNameFilter: buffNameFilter,
                    inclusiveBuffFilter: inclusiveBuffFilter
                    );
                var old = p.PassThrough[iterator];
                try
                {
                    foreach (var i in result)
                    {
                        p.PassThrough[iterator] = i;
                        p.Exec(c);
                    }
                }
                catch (BreakLoop) { }
                p.PassThrough[iterator] = old;
                return 0;
            }
        }
    }
}