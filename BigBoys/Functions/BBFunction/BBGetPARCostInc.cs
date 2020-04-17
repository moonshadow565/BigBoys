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
        public sealed class BBGetPARCostInc : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit spellSlotOwner, "SpellSlotOwner", require: true);
                p.GetBBParam(out SlotsType slotType, "SlotType", require: true);
                p.GetBBParam(out int spellSlot, "SpellSlot", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                var result = c.BBGetPARCostInc(
                    spellSlotOwner: spellSlotOwner,
                    slotType: slotType,
                    spellSlot: spellSlot,
                    PARType: PARType
                    );
                p.SetBBParam("IncCost", result);
                return 0;
            }
        }
    }
}