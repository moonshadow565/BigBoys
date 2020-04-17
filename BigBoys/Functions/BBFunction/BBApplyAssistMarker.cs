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
        public sealed class BBApplyAssistMarker : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out IUnit source, "Source", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                c.BBApplyAssistMarker(
                    target: target,
                    source: source,
                    duration: duration
                    );
                return 0;
            }
        }
    }
}