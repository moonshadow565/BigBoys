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
        public sealed class BBPushCharacterFade : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float fadeAmount, "FadeAmount", require: true);
                p.GetBBParam(out float fadeTime, "fadeTime", require: true);
                var result = c.BBPushCharacterFade(
                    target: target,
                    fadeAmount: fadeAmount,
                    fadeTime: fadeTime
                    );
                p.SetBBParam("ID", result);
                return 0;
            }
        }
    }
}