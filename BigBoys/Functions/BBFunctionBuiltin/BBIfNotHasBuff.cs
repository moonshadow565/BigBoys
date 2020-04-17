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
        public sealed class BBIfNotHasBuff : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner");
                var buffName = p.GetInBlock("BuffName").AsString().Require();
                p.GetBBParam(out IUnit attacker, "Caster");
                var result = c.HasBuff(
                    owner: owner,
                    buffName: buffName,
                    attacker: attacker
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