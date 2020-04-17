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
        public sealed class BBGetGold : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                p.GetBBParam(out float delta, "Delta", require: true);
                var result = c.BBLuaGetGold(
                    target: target,
                    delta: delta
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }
    }
}