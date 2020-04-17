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
        public sealed class BBIncHealth : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                var healer = p.GetInVar("HealerVar").AsUnit().Default();
                c.BBIncHealth(
                    target: target,
                    delta: delta,
                    healer: healer
                    );
                return 0;
            }
        }
    }
}