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
        public sealed class BBAddUnitPerceptionBubble : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float radius, "Radius", require: true);
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out TeamID team, "Team");
                p.GetBBParam(out IUnit specificUnitsClientOnly, "SpecificUnitsClientOnly");
                p.GetBBParam(out bool revealSteath, "RevealSteath", require: true);
                p.GetBBParam(out IUnit revealSpecificUnitOnly, "RevealSpecificUnitOnly");
                var result = c.BBAddUnitPerceptionBubble(
                    radius: radius,
                    target: target,
                    duration: duration,
                    team: team,
                    specificUnitsClientOnly: specificUnitsClientOnly,
                    revealSteath: revealSteath,
                    revealSpecificUnitOnly: revealSpecificUnitOnly
                    );
                p.SetBBParam("BubbleID", result);
                return 0;
            }
        }
    }
}