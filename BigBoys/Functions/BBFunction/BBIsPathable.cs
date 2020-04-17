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
        public sealed class BBIsPathable : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 destPos, "DestPos", require: true);
                var result = c.BBIsPathable(
                    destPos: destPos
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }
    }
}