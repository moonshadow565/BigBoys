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
        public sealed class BBFadeInColorFadeEffect : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out int colorRed, "ColorRed", require: true);
                p.GetBBParam(out int colorGreen, "ColorGreen", require: true);
                p.GetBBParam(out int colorBlue, "ColorBlue", require: true);
                p.GetBBParam(out float fadeTime, "FadeTime", require: true);
                p.GetBBParam(out float maxWeight, "MaxWeight", require: true);
                p.GetBBParam(out TeamID specificToTeam, "SpecificToTeam", require: true);
                c.BBFadeInColorFadeEffect(
                    colorRed: colorRed,
                    colorGreen: colorGreen,
                    colorBlue: colorBlue,
                    fadeTime: fadeTime,
                    maxWeight: maxWeight,
                    specificToTeam: specificToTeam
                    );
                return 0;
            }
        }
    }
}