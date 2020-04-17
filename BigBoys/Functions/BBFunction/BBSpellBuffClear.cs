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
        public sealed class BBSpellBuffClear : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                var buffName = p.GetInBlock("BuffName").AsString().Default();
                c.BBSpellBuffClear(
                    target: target,
                    buffName: buffName
                    );
                return 0;
            }
        }
    }
}