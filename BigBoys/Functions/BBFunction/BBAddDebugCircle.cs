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
        public sealed class BBAddDebugCircle : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit");
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float radius, "Radius", require: true);
                p.GetBBParam(out int colorR, "ColorR", require: true);
                p.GetBBParam(out int colorG, "ColorG", require: true);
                p.GetBBParam(out int colorB, "ColorB", require: true);
                p.GetBBParam(out int colorA, "ColorA", require: true);
                var result = c.BBAddDebugCircle(
                    unit: unit,
                    center: center,
                    radius: radius,
                    colorR: colorR,
                    colorG: colorG,
                    colorB: colorB,
                    colorA: colorA
                );
                p.SetBBParam("DebugCircleID", result);
                return 0;
            }
        }
    }
}