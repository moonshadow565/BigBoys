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
        public sealed class BBModifyPosition : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 position, "Position", require: true);
                p.GetBBParam(out float x, "x", require: true);
                p.GetBBParam(out float y, "x", require: true);
                p.GetBBParam(out float z, "x", require: true);
                position.X += x;
                position.Y += y;
                position.Z += z;
                p.SetBBParam("Position", position);
                return 0;
            }
        }
    }
}