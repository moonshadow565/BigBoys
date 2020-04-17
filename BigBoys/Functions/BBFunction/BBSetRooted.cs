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
        public sealed class BBSetRooted : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldRoot = p.GetInBlock("ShouldRoot").AsBool().Require();
                c.BBSetRooted(
                    target: target,
                    shouldRoot: shouldRoot
                    );
                return 0;
            }
        }
    }
}