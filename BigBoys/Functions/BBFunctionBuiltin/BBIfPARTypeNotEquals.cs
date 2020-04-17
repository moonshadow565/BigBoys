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
        public sealed class BBIfPARTypeNotEquals : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner");
                var parType = p.GetInBlock("PARType").AsEnum<PARType>().Require();
                var result = c.HasPARType(
                    owner: owner,
                    parType: parType
                    );
                if (!result)
                {
                    p.Exec(c);
                    return 1;
                }
                return 0;
            }
        }
    }
}