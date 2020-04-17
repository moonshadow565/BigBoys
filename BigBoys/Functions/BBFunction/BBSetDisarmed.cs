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
        public sealed class BBSetDisarmed : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldDisarm = p.GetInBlock("ShouldDisarm").AsBool().Require();
                c.BBSetDisarmed(
                    target: target,
                    shouldDisarm: shouldDisarm
                    );
                return 0;
            }
        }
    }
}