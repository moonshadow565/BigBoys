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
        public sealed class BBSpellBuffAdd : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                p.GetBBParam(out int numberOfStacks, "NumberOfStacks", @default: 1);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out BuffAddType buffAddType, "BuffAddType", require: true);
                p.GetBBParam(out int maxStack, "MaxStack", require: true);
                p.GetBBParam(out int tickRate, "TickRate", require: true);
                p.GetBBParam(out bool stacksExclusive, "StacksExclusive", @default: true);
                p.GetBBParam(out bool canMitigateDuration, "CanMitigateDuration");
                p.GetBBParam(out bool isHiddenOnClient, "IsHiddenOnClient");
                var buffName = p.GetInBlock("BuffName").AsString().Require();
                var buffType = p.GetInBlock("BuffType").AsEnum<BuffType>().Require();
                var buffVars = p.GetInVarOrPass("BuffVarsTable", "NextBuffVar").AsTable() ?? new Table();
                c.BBSpellBuffAdd(
                    target: target,
                    attacker: attacker,
                    numberOfStacks: numberOfStacks,
                    duration: duration,
                    buffAddType: buffAddType,
                    maxStack: maxStack,
                    tickRate: tickRate,
                    stacksExclusive: stacksExclusive,
                    canMitigateDuration: canMitigateDuration,
                    isHiddenOnClient: isHiddenOnClient,
                    buffName: buffName,
                    buffType: buffType,
                    buffVars: buffVars
                    );
                return 0;
            }
        }
    }
}