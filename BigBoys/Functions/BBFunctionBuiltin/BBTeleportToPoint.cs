using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using System.Numerics;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBFunction
    {
        public sealed class BBTeleportToPoint : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var x = p.GetInVarTableOrBlock("XVarTable", "XVar", "X", true).AsFloat().Require();
                var y = p.GetInVarTableOrBlock("YVarTable", "YVar", "Y", true).AsFloat().Require();
                var z = p.GetInVarTableOrBlock("ZVarTable", "ZVar", "Z", true).AsFloat().Require();
                c.BBTeleportToPoint(
                    owner: p.GetInVar("OwnerVar").AsUnit(),
                    position: new Vector3(x, y, z)
                    );
                return 0;
            }
        }
    }
}