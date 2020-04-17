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
        public sealed class BBIfHasBuffOfType : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target");
                var buffType = p.GetInBlock("BuffType").AsEnum<BuffType>().Require();
                var result = c.HasBuffOfType(
                    target: target,
                    buffType: buffType
                    );
                if (result)
                {
                    p.Exec(c);
                    return 1;
                }
                return 0;
            }
        }
    }
}