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
        public sealed class BBGetGroundHeight : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 queryPos, "QueryPos", require: true);
                var result = c.BBGetGroundHeight(
                    queryPos: queryPos
                    );
                p.SetBBParam("GroundPos", result);
                return 0;
            }
        }
    }
}