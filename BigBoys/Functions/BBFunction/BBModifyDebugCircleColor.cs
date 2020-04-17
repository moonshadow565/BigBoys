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
        public sealed class BBModifyDebugCircleColor : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out int debugCircleID, "DebugCircleID", require: true);
                p.GetBBParam(out int colorR, "ColorR", require: true);
                p.GetBBParam(out int colorG, "ColorG", require: true);
                p.GetBBParam(out int colorB, "ColorB", require: true);
                p.GetBBParam(out int colorA, "ColorA", require: true);
                c.BBModifyDebugCircleColor(
                    debugCircleID: debugCircleID,
                    colorR: colorR,
                    colorG: colorG,
                    colorB: colorB,
                    colorA: colorA
                    );
                return 0;
            }
        }
    }
}