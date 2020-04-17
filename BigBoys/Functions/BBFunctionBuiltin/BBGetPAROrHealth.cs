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
        public sealed class BBGetPAROrHealth : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var func = p.GetInBlock("Function") as BBOpPAROrHealthGet;
                var result = func.Require().Call(
                    c,
                    p.GetInVar("OwnerVar").AsUnit(),
                    p.GetInBlock("PARType").AsEnum<PARType>()
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }
    }
}