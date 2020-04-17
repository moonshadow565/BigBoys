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
        public sealed class BBIncPermanentPercentPARRegenMod : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                c.BBIncPermanentPercentPARRegenMod(
                    target: target,
                    delta: delta,
                    PARType: PARType
                    );
                return 0;
            }
        }
    }
}