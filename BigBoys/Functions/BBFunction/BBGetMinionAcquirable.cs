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
        public sealed class BBGetMinionAcquirable : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit");
                var result = c.BBGetMinionAcquirable(
                    unit: unit
                    );
                p.SetBBParam("Value", result);
                return 0;
            }
        }
    }
}