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
        public sealed class BBRequireVar : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetInVarTable("RequiredVar", "RequiredVarTable").Require();
                return 0;
            }
        }
    }
}