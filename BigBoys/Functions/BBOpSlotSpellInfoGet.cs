using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract class BBOpSlotSpellInfoGet
    {
        private BBOpSlotSpellInfoGet() {}
        
        public abstract object Call(IContext c, IUnit target, SpellSlot slot);

        public sealed class GetSlotSpellCooldownTime : BBOpSlotSpellInfoGet
        {
            public override object Call(IContext c, IUnit target, SpellSlot slot) => c.GetSlotSpellCooldownTime(target, slot);
        }

        public sealed class GetSlotSpellLevel : BBOpSlotSpellInfoGet
        {
            public override object Call(IContext c, IUnit target, SpellSlot slot) => c.GetSlotSpellLevel(target, slot);
        }

        public sealed class GetSlotSpellName : BBOpSlotSpellInfoGet
        {
            public override object Call(IContext c, IUnit target, SpellSlot slot) => c.GetSlotSpellName(target, slot);
        }
    }
}
