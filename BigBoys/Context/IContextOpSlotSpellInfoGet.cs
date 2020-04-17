using System;
using BigBoys.Enums;
using BigBoys.Execution;
using BigBoys.Lua;

namespace BigBoys.Context
{
    public partial interface IContext
    {
        float GetSlotSpellCooldownTime(IUnit target, SpellSlot slot);
        int GetSlotSpellLevel(IUnit target, SpellSlot slot);
        string GetSlotSpellName(IUnit target, SpellSlot slot);
    }
}
