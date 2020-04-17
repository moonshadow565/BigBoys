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
        public sealed class BBGetConnectedStatus : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                var result = c.BBGetConnectedStatus(
                    unit: unit
                    );
                p.SetBBParam("UnitConnected", result);
                return 0;
            }
        }
    }
}