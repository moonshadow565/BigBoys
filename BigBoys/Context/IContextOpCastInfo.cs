using System;
using System.Numerics;
using BigBoys.Enums;
using BigBoys.Execution;
using BigBoys.Lua;

namespace BigBoys.Context
{
    public partial interface IContext
    {
        GObjID GetCasterID();
        int GetCastSpellLevelPlusOne();
        Table GetCastSpellLuaInfo();
        Vector3 GetCastSpellTargetPos();
        int GetCastSpellTargetsHitPlusOne();
        bool GetIsAttackOverride();
        string GetSpellName();
        int GetSpellSlot();
    }
}
