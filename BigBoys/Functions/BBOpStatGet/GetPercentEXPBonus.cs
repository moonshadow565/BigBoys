﻿using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBOpStatGet
    {
        public sealed class GetPercentEXPBonus : BBOpStatGet
        {  
            public override float Call(IContext c, IUnit target) => c.GetPercentEXPBonus(target);
        }
    }
}
