using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBFunction
    {
        public sealed class BBSetScaleSkinCoef : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var scale = p.GetInVarTableOrBlock("ScaleVarTable", "ScaleVar", "Scale").AsFloat().Require();
                p.GetBBParam(out IUnit owner, "Owner");
                c.SetScaleSkinCoef(
                    scale: scale,
                    owner: owner
                    );
                return 0;
            }
        }
    }
}