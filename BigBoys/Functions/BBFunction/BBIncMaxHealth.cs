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
        public sealed class BBIncMaxHealth : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out bool incCurrentHealth, "IncCurrentHealth", require: true);
                c.BBIncMaxHealth(
                    target: target,
                    delta: delta,
                    incCurrentHealth: incCurrentHealth
                    );
                return 0;
            }
        }
    }
}