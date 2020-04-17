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
        public sealed class BBApplyNearSight : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyNearSight(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }
    }
}