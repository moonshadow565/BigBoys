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
        public sealed class BBPlayAnimation : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out string animationName, "AnimationName", require: true);
                p.GetBBParam(out float scaleTime, "ScaleTime", require: true);
                p.GetBBParam(out bool loop, "Loop");
                p.GetBBParam(out bool blend, "Blend", @default: true);
                p.GetBBParam(out bool @lock, "Lock", @default: true);
                c.BBPlayAnimation(
                    target: target,
                    animationName: animationName,
                    scaleTime: scaleTime,
                    loop: loop,
                    blend: blend,
                    @lock: @lock
                    );
                return 0;
            }
        }
    }
}