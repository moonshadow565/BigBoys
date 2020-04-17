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
        public sealed class BBGetMissilePosFromID : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out int targetID, "TargetID", require: true);
                var result = c.BBGetMissilePosFromID(
                    targetID: targetID
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }
    }
}