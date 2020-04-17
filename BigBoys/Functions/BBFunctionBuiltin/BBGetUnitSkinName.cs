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
        public sealed class BBGetUnitSkinName : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit();
                var result = c.GetUnitSkinName(
                    target: target
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result);
                return 0;
            }
        }
    }
}