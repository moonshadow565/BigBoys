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
        public sealed class BBOverrideAutoAttack : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out SlotsType slotType, "SlotType", require: true);
                p.GetBBParam(out int spellSlot, "SpellSlot", require: true);
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out int autoAttackSpellLevel, "AutoAttackSpellLevel", require: true);
                p.GetBBParam(out bool cancelAttack, "CancelAttack", @default: true);
                c.BBOverrideAutoAttack(
                    slotType: slotType,
                    spellSlot: spellSlot,
                    owner: owner,
                    autoAttackSpellLevel: autoAttackSpellLevel,
                    cancelAttack: cancelAttack
                    );
                return 0;
            }
        }
    }
}