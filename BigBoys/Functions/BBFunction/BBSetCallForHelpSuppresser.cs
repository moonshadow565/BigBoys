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
        public sealed class BBSetCallForHelpSuppresser : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldSuppressCallForHelp = p.GetInBlock("ShouldSuppressCallForHelp").AsBool().Require();
                c.BBSetCallForHelpSuppresser(
                    target: target,
                    shouldSuppressCallForHelp: shouldSuppressCallForHelp
                    );
                return 0;
            }
        }
    }
}