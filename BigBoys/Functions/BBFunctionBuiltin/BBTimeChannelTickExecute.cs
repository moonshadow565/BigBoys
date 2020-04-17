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
        public sealed class BBTimeChannelTickExecute : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float accumTime, "AccumTime", require: true);
                p.GetBBParam(out float tickTime, "TimeTick", require: true);
                if (accumTime >= 0)
                {
                    p.PassThrough["AccumTime"] = -tickTime;
                    p.Exec(c);
                }
                return 0;
            }
        }
    }
}