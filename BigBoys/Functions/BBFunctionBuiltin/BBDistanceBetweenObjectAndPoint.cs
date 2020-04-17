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
        public sealed class BBDistanceBetweenObjectAndPoint : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var @object = p.GetInVar("ObjectVar").AsUnit();
                var point = p.GetInVarTable("PointVarTable", "PointVar", true).AsVector3() ?? default;
                var result = c.DistanceBetweenObjectAndPoint(
                    @object: @object,
                    point: point
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }
    }
}