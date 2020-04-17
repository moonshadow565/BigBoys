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
        public sealed class BBSetIgnoreCallForHelp : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldIgnoreCallForHelp = p.GetInBlock("ShouldIgnoreCallForHelp").AsBool().Require();
                c.BBSetIgnoreCallForHelp(
                    target: target,
                    shouldIgnoreCallForHelp: shouldIgnoreCallForHelp
                    );
                return 0;
            }
        }
    }
}