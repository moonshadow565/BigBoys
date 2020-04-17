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
        public sealed class BBSetUseSlotSpellCooldownTime : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out bool broadcastEvent, "BroadcastEvent");
                p.GetBBParam(out float src, "Src", require: true);
                c.BBSetUseSlotSpellCooldownTime(
                    owner: owner,
                    broadcastEvent: broadcastEvent,
                    src: src
                    );
                return 0;
            }
        }
    }
}