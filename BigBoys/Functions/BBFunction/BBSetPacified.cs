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
        public sealed class BBSetPacified : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldPacified = p.GetInBlock("ShouldPacified").AsBool().Require();
                c.BBSetPacified(
                    target: target,
                    shouldPacified: shouldPacified
                    );
                return 0;
            }
        }
    }
}