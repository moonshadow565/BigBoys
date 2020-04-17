using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBOpSlotSpellInfoGet
    {
        private BBOpSlotSpellInfoGet() {}
        
        public abstract object Call(IContext c, IUnit target, SpellSlot slot);
    }
}
