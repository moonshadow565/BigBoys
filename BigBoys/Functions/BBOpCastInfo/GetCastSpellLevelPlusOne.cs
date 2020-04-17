﻿using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBOpCastInfo
    {
        public sealed class GetCastSpellLevelPlusOne : BBOpCastInfo
        {  
            public override object Call(IContext c) => c.GetCastSpellLevelPlusOne();
        }
    }
}
