using System;
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
        public sealed class BBGetNearSight : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Owner", require: true);
                var result = c.BBGetNearSight(
                    unit: unit
                    );
                p.SetBBParam("NearSight", result);
                return 0;
            }
        }
    }
}