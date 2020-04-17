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
        public sealed class BBGetPointByUnitFacingOffset : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                p.GetBBParam(out float distance, "Distance", require: true);
                p.GetBBParam(out float offsetAngle, "OffsetAngle", require: true);
                var result = c.BBGetPointByUnitFacingOffset(
                    unit: unit,
                    distance: distance,
                    offsetAngle: offsetAngle
                    );
                p.SetBBParam("Position", result);
                return 0;
            }
        }
    }
}