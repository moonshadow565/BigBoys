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
        public sealed class BBPingUnit : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out bool playSound, "PlaySound", @default: true);
                c.BBPingUnit(
                    owner: owner,
                    target: target,
                    playSound: playSound
                    );
                return 0;
            }
        }
    }
}