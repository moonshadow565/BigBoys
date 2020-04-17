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
        public sealed class BBSetTargetingType : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                p.GetBBParam(out TargetType targetType, "TargetType", require: true);
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBSetTargetingType(
                    slot: slot,
                    targetType: targetType,
                    target: target
                    );
                return 0;
            }
        }
    }
}