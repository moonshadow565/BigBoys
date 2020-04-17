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
        public sealed class BBSetNearSight : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                p.GetBBParam(out bool isNearSight, "IsNearSight", require: true);
                c.BBSetNearSight(
                    unit: unit,
                    isNearSight: isNearSight
                    );
                return 0;
            }
        }
    }
}