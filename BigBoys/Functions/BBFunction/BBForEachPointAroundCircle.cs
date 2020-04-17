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
        public sealed class BBForEachPointAroundCircle : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float radius, "Radius", require: true);
                p.GetBBParam(out int iterations, "Iterations", require: true);
                var result = c.BBForEachPointAroundCircle(
                    center: center,
                    radius: radius,
                    iterations: iterations
                    );
                try
                {
                    foreach (var i in result)
                    {
                        p.SetBBParam("Iterator", i);
                        p.Exec(c);
                    }
                }
                catch (BreakLoop) { }
                return 0;
            }
        }
    }
}