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
        public sealed class BBRemoveDebugCircle : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out int debugCircleID, "DebugCircleID", require: true);
                c.BBRemoveDebugCircle(
                    debugCircleID: debugCircleID
                    );
                return 0;
            }
        }
    }
}