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
        public sealed class BBGetOffsetAngle : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                p.GetBBParam(out Vector3 offsetPoint, "OffsetPoint", require: true);
                var result = c.BBGetOffsetAngle(
                    unit: unit,
                    offsetPoint: offsetPoint
                    );
                p.SetBBParam("OutputAngle", result);
                return 0;
            }
        }
    }
}