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
        public sealed class BBFadeOutColorFadeEffect : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float fadeTime, "FadeTime", require: true);
                p.GetBBParam(out TeamID specificToTeam, "SpecificToTeam", require: true);
                c.BBFadeOutColorFadeEffect(
                    fadeTime: fadeTime,
                    specificToTeam: specificToTeam
                    );
                return 0;
            }
        }
    }
}