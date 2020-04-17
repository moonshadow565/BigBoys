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
        public sealed class BBInvalidateUnit : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.PassThrough[p.GetInBlock("TargetVar").AsString().Require()] = null;
                return 0; 
            }
        }
    }
}