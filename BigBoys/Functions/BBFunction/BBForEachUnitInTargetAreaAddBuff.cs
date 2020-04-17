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
        public sealed class BBForEachUnitInTargetAreaAddBuff : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float range, "Range", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                p.GetBBParam(out IUnit buffAttacker, "BuffAttacker", require: true);
                p.GetBBParam(out int buffNumberOfStacks, "BuffNumberOfStacks", @default: 1);
                p.GetBBParam(out float buffDuration, "BuffDuration", require: true);
                p.GetBBParam(out BuffAddType buffAddType, "BuffAddType", require: true);
                p.GetBBParam(out int tickRate, "TickRate", require: true);
                p.GetBBParam(out bool isHiddenOnClient, "IsHiddenOnClient");
                var buffName = p.GetInBlock("BuffName").AsString().Require();
                p.GetBBParam(out int buffMaxStack, "BuffMaxStack", require: true);
                var buffType = p.GetInBlock("BuffType").AsEnum<BuffType>().Require();
                var buffVars = p.GetInVarOrPass("BuffVarsTable", "NextBuffVar").AsTable() ?? new Table();
                c.BBForEachUnitInTargetAreaAddBuff(
                    attacker: attacker,
                    center: center,
                    range: range,
                    flags: flags,
                    buffNameFilter: buffNameFilter,
                    inclusiveBuffFilter: inclusiveBuffFilter,
                    buffAttacker: buffAttacker,
                    buffNumberOfStacks: buffNumberOfStacks,
                    buffDuration: buffDuration,
                    buffAddType: buffAddType,
                    tickRate: tickRate,
                    isHiddenOnClient: isHiddenOnClient,
                    buffName: buffName,
                    buffMaxStack: buffMaxStack,
                    buffType: buffType,
                    buffVars: buffVars
                    );
                return 0;
            }
        }
    }
}