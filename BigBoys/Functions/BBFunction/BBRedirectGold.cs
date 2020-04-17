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
        public sealed class BBRedirectGold : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit redirectSource, "RedirectSource", require: true);
                p.GetBBParam(out IUnit redirectTarget, "RedirectTarget");
                c.BBRedirectGold(
                    redirectSource: redirectSource,
                    redirectTarget: redirectTarget
                    );
                return 0;
            }
        }
    }
}