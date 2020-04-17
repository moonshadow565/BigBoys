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
        public sealed class BBSay : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var toSay = p.GetInBlock("ToSay").ToStringOrEmpty();
                var src = p.GetInVarTable("SrcVarTable", "SrcVar").ToStringOrEmpty();
                p.GetBBParam(out IUnit owner, "Owner");
                c.Say(
                    toSay: toSay,
                    src: src,
                    owner: owner
                    );
                return 0;
            }
        }
    }
}