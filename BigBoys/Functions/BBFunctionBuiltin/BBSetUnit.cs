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
        public sealed class BBSetUnit : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var result = p.GetInVar("SrcVar").AsUnit();
                p.PassThrough[p.GetInBlock("DestVar").ToString().Require()] = result;
                return 0;
            }
        }
    }
}