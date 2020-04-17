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
        public sealed class BBSetDodgePiercing : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out bool value, "Value", require: true);
                c.BBSetDodgePiercing(
                    target: target,
                    value: value
                    );
                return 0;
            }
        }
    }
}