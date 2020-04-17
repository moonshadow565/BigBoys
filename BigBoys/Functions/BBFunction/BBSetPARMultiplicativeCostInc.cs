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
        public sealed class BBSetPARMultiplicativeCostInc : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit spellSlotOwner, "SpellSlotOwner", require: true);
                p.GetBBParam(out SlotsType slotType, "SlotType", require: true);
                p.GetBBParam(out int spellSlot, "SpellSlot", require: true);
                p.GetBBParam(out float cost, "Cost", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                c.BBSetPARMultiplicativeCostInc(
                    spellSlotOwner: spellSlotOwner,
                    slotType: slotType,
                    spellSlot: spellSlot,
                    cost: cost,
                    PARType: PARType
                    );
                return 0;
            }
        }
    }
}