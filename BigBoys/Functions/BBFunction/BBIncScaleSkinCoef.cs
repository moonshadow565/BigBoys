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
        public sealed class BBIncScaleSkinCoef : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float scale, "Scale", require: true);
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                c.BBIncScaleSkinCoef(
                    scale: scale,
                    owner: owner
                    );
                return 0;
            }
        }
    }
}