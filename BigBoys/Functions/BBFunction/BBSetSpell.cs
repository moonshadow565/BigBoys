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
        public sealed class BBSetSpell : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                p.GetBBParam(out string spellName, "SpellName", require: true);
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBSetSpell(
                    slot: slot,
                    spellName: spellName,
                    target: target
                    );
                return 0;
            }
        }
    }
}