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
        public sealed class BBSetStunned : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldStun = p.GetInBlock("ShouldStun").AsBool().Require();
                c.BBSetStunned(
                    target: target,
                    shouldStun: shouldStun
                    );
                return 0;
            }
        }
    }
}