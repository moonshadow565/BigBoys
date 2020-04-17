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
        public sealed class BBGetRandomPointInAreaUnit : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float radius, "Radius", require: true);
                p.GetBBParam(out float innerRadius, "InnerRadius");
                var result = c.BBGetRandomPointInAreaUnit(
                    target: target,
                    radius: radius,
                    innerRadius: innerRadius
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }
    }
}