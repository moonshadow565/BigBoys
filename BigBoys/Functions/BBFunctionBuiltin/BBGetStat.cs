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
        public sealed class BBGetStat : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var stat = p.GetInBlock("Stat") as BBOpStatGet;
                var result = stat.Require().Call(
                    c,
                    p.GetInVar("TargetVar").AsUnit()
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result);
                return 0;
            }
        }
    }
}