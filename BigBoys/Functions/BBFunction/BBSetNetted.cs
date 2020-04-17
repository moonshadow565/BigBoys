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
        public sealed class BBSetNetted : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldNet = p.GetInBlock("ShouldNet").AsBool().Require();
                c.BBSetNetted(
                    target: target,
                    shouldNet: shouldNet
                    );
                return 0;
            }
        }
    }
}