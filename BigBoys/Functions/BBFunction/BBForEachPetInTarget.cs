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
        public sealed class BBForEachPetInTarget : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string iterator, "IteratorVar", @default: "Owner");
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                var result = c.BBForEachPetInTarget(
                    target: target,
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