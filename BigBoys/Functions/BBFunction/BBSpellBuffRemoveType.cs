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
        public sealed class BBSpellBuffRemoveType : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                var type = p.GetInBlock("Type").AsEnum<BuffType>().Require();
                c.BBSpellBuffRemoveType(
                    target: target,
                    type: type
                    );
                return 0;
            }
        }
    }
}