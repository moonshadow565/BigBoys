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
        public sealed class BBSetNotTargetableToTeam : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out bool toAlly, "ToAlly", require: true);
                p.GetBBParam(out bool toEnemy, "ToEnemy", require: true);
                c.BBSetNotTargetableToTeam(
                    target: target,
                    toAlly: toAlly,
                    toEnemy: toEnemy
                    );
                return 0;
            }
        }
    }
}