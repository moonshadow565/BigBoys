using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBFunction
    {
        public sealed class BBGetCastInfo : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var info = p.GetInBlock("Info") as BBOpCastInfo;
                var result = info.Require().Call(c);
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }
    }
}