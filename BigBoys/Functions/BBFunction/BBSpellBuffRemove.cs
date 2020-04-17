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
        public sealed class BBSpellBuffRemove : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                var buffName = p.GetInBlock("BuffName").AsString().Default();
                p.GetBBParam(out float resetDuration, "ResetDuration");
                c.BBSpellBuffRemove(
                    target: target,
                    attacker: attacker,
                    buffName: buffName,
                    resetDuration: resetDuration
                    );
                return 0;
            }
        }
    }
}