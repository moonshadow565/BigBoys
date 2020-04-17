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
        public sealed class BBModifyDebugCircleRadius : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out int debugCircleID, "DebugCircleID", require: true);
                p.GetBBParam(out float radius, "Radius", require: true);
                c.BBModifyDebugCircleRadius(
                    debugCircleID: debugCircleID,
                    radius: radius
                    );
                return 0;
            }
        }
    }
}