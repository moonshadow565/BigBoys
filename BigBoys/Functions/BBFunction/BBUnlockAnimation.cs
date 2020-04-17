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
        public sealed class BBUnlockAnimation : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out bool blend, "Blend", @default: true);
                c.BBUnlockAnimation(
                    owner: owner,
                    blend: blend
                    );
                return 0;
            }
        }
    }
}