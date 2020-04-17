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
        public sealed class BBOverrideCastRange : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit spellSlotOwner, "SpellSlotOwner", require: true);
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                p.GetBBParam(out float range, "Range", require: true);
                c.BBOverrideCastRange(
                    spellSlotOwner: spellSlotOwner,
                    slot: slot,
                    range: range
                    );
                return 0;
            }
        }
    }
}