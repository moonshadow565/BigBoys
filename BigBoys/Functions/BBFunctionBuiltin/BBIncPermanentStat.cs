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
        public sealed class BBIncPermanentStat : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var delta = 0.0f;
                delta += p.GetInBlock("Delta").AsFloat() ?? 0.0f;
                delta += p.GetInByLevel("DeltaByLevel").AsFloat() ?? 0.0f;
                delta += p.GetInBlock("Delta").AsFloat() ?? 0.0f;
                var stat = p.GetInBlock("Stat") as BBOpStatInc;
                stat.Require().Call(
                    c,
                    delta,
                    p.GetInVar("TargetVar").AsUnit()
                    );
                return 0;
            }
        }
    }
}