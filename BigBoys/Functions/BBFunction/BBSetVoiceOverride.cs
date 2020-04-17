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
        public sealed class BBSetVoiceOverride : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out string overrideSuffix, "OverrideSuffix", require: true);
                c.BBSetVoiceOverride(
                    target: target,
                    overrideSuffix: overrideSuffix
                    );
                return 0;
            }
        }
    }
}