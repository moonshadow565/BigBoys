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
        public sealed class BBSetPARColorOverride : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit spellSlotOwner, "SpellSlotOwner", require: true);
                p.GetBBParam(out int colorR, "ColorR", require: true);
                p.GetBBParam(out int colorG, "ColorG", require: true);
                p.GetBBParam(out int colorB, "ColorB", require: true);
                p.GetBBParam(out int colorA, "ColorA", require: true);
                p.GetBBParam(out int fadeR, "FadeR", require: true);
                p.GetBBParam(out int fadeG, "FadeG", require: true);
                p.GetBBParam(out int fadeB, "FadeB", require: true);
                p.GetBBParam(out int fadeA, "FadeA", require: true);
                c.BBSetPARColorOverride(
                    spellSlotOwner: spellSlotOwner,
                    colorR: colorR,
                    colorG: colorG,
                    colorB: colorB,
                    colorA: colorA,
                    fadeR: fadeR,
                    fadeG: fadeG,
                    fadeB: fadeB,
                    fadeA: fadeA
                    );
                return 0;
            }
        }
    }
}