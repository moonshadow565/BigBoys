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
        public sealed class BBGetBuffStartTime : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out string buffName, "BuffName", require: true);
                var result = c.BBGetBuffStartTime(
                    target: target,
                    buffName: buffName
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }
    }
}