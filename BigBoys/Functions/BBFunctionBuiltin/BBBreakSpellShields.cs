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
        public sealed class BBBreakSpellShields : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit();
                var buffVars = p.GetInPass("NextBuffVars").AsTable();
                c.BreakSpellShields(
                    target: target,
                    buffVars: buffVars
                    );
                return 0;
            }
        }
    }
}