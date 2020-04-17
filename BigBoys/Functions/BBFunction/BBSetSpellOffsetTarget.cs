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
        public sealed class BBSetSpellOffsetTarget : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                p.GetBBParam(out string spellName, "SpellName", require: true);
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out IUnit offsetTarget, "OffsetTarget", require: true);
                c.BBSetSpellOffsetTarget(
                    slot: slot,
                    spellName: spellName,
                    owner: owner,
                    offsetTarget: offsetTarget
                    );
                return 0;
            }
        }
    }
}