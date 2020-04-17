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
        public sealed class BBApplyBrushCircle : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 pos, "Pos", require: true);
                p.GetBBParam(out float radius, "Radius", require: true);
                var result = c.BBApplyBrushCircle(
                    pos: pos,
                    radius: radius
                    );
                p.SetBBParam("ID", result);
                return 0;
            }
        }
    }
}