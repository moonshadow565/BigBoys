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
        public sealed class BBSkipNextAutoAttack : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBSkipNextAutoAttack(
                    target: target
                   );
                return 0;
            }
        }
    }
}