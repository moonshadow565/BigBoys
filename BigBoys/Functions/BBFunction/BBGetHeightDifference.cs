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
        public sealed class BBGetHeightDifference : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 pos1, "Pos1", require: true);
                p.GetBBParam(out Vector3 pos2, "Pos2", require: true);
                var result = c.BBGetHeightDifference(
                    pos1: pos1,
                    pos2: pos2
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }
    }
}