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
        public sealed class BBGetNearestPassablePosition : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 position, "Position", require: true);
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                var result = c.BBGetNearestPassablePosition(
                    position: position,
                    owner: owner
                    );
                p.SetBBParam("NewPosition", result);
                return 0;
            }
        }
    }
}