﻿using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBOpSlotSpellInfoGet
    {
        public sealed class GetSlotSpellLevel : BBOpSlotSpellInfoGet
        {  
            public override object Call(IContext c, IUnit target, SpellSlot slot) => c.GetSlotSpellLevel(target, slot);
        }
    }
}
