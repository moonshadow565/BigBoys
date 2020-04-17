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
        public sealed class BBDistanceBetweenPoints : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var point1 = p.GetInVarTable("PointVar1Table", "Point1Var", true).AsVector3() ?? default;
                var point2 = p.GetInVarTable("PointVar2Table", "Point2Var", true).AsVector3() ?? default;
                var result = c.DistanceBetweenPoints(
                    point1: point1,
                    point2: point2
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }
    }
}