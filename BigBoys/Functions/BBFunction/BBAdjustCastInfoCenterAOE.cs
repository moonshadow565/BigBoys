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
        public sealed class BBAdjustCastInfoCenterAOE : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var owner = p.GetInPass("Owner").AsUnit().Require();
                p.GetBBParam(out float radius, "Radius", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                c.BBAdjustCastInfoCenterAOE(
                    owner: owner,
                    radius: radius,
                    flags: flags
                    );
                return 0;
            }
        }
    }
}