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
        public sealed class BBSetSlotSpellCooldownTimeVer2 : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                p.GetBBParam(out bool broadcastEvent, "BroadcastEvent");
                p.GetBBParam(out float src, "Src", require: true);
                c.BBSetSlotSpellCooldownTimeVer2(
                    owner: owner,
                    slot: slot,
                    broadcastEvent: broadcastEvent,
                    src: src
                    );
                return 0;
            }
        }
    }
}