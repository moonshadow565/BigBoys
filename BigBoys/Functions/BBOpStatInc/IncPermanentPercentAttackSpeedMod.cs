﻿using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBOpStatInc
    {
        public sealed class IncPermanentPercentAttackSpeedMod : BBOpStatInc
        {  
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentAttackSpeedMod(delta, target);
        }
    }
}
