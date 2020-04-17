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
        public sealed class BBGetGameTime : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var result = c.BBGetGameTime();
                p.SetBBParam("Seconds", result);
                return 0; 
            }
        }
    }
}