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
        public sealed class BBSetSpellToolTipVar : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float value, "Value", require: true);
                p.GetBBParam(out int index, "Index", require: true);
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBSetSpellToolTipVar(
                    value: value,
                    index: index,
                    slot: slot,
                    target: target
                    );
                return 0;
            }
        }
    }
}