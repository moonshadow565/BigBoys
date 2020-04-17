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
        public sealed class BBGetRandomPointInAreaPosition : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 pos, "Pos", require: true);
                p.GetBBParam(out float radius, "Radius", require: true);
                p.GetBBParam(out float innerRadius, "InnerRadius");
                var result = c.BBGetRandomPointInAreaPosition(
                    pos: pos,
                    radius: radius,
                    innerRadius: innerRadius
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }
    }
}