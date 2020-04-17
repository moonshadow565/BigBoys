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
        public sealed class BBClearOverrideAnimation : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out string toOverrideAnim, "ToOverrideAnim", require: true);
                c.BBClearOverrideAnimation(
                    owner: owner,
                    toOverrideAnim: toOverrideAnim
                    );
                return 0;
            }
        }
    }
}