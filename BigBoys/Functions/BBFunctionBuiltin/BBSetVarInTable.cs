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
        public sealed class BBSetVarInTable : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var result = p.GetInByLevel("SrcValueByLevel") ?? p.GetInVarTableOrBlock("SrcVarTable", "SrcVar", "SrcValue");
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }
    }
}