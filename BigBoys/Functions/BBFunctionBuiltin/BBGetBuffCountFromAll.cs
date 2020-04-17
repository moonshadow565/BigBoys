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
        public sealed class BBGetBuffCountFromAll : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit();
                var buffName = p.GetInBlock("BuffName").AsString().Require();
                var result = c.SpellBuffCount(
                    target: target,
                    buffName: buffName,
                    caster: null
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }
    }
}