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
        public sealed class BBSealSpellSlot : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out SlotsType slotType, "SlotType", require: true);
                p.GetBBParam(out int spellSlot, "SpellSlot", require: true);
                p.GetBBParam(out bool state, "State", require: true);
                p.GetBBParam(out SpellbookType spellbookType, "SpellbookType");
                c.BBSealSpellSlot(
                    target: target,
                    slotType: slotType,
                    spellSlot: spellSlot,
                    state: state,
                    spellbookType: spellbookType
                    );
                return 0;
            }
        }
    }
}