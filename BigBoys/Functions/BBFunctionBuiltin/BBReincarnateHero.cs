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
        public sealed class BBReincarnateHero : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVarTable("TargetVarTable", "TargetVar").AsUnit();
                c.ReincarnateNonDeadHero(
                    target: target
                    );
                return 0;
            }
        }
    }
}