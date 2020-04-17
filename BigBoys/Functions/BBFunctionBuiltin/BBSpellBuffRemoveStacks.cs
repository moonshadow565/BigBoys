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
        public sealed class BBSpellBuffRemoveStacks : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit();
                var buffName = p.GetInBlock("BuffName").AsString();
                var attacker = p.GetInVar("AttackerVar").AsUnit();
                var numStacks = p.GetInBlock("NumStacks").AsInt().Require();
                c.SpellBuffRemoveStacks(
                    target: target,
                    buffName: buffName,
                    attacker: attacker,
                    numStacks: numStacks
                    );
                return 0;
            }
        }
    }
}