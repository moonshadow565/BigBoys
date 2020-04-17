using System;
using System.Numerics;
using BigBoys.Enums;
using BigBoys.Execution;
using BigBoys.Lua;

namespace BigBoys.Context
{
    public partial interface IContext
    {
        void Alert(string message, string src);

        void BreakSpellShields(IUnit target, Table buffVars);

        void Say(string toSay, string src, IUnit owner);

        void DefUpdateAura(Vector3 center, float range, UnitScanType unitScan, string buffName);

        float DistanceBetweenObjectAndPoint(IUnit @object, Vector3 point);

        float DistanceBetweenObjects(IUnit object1, IUnit object2);

        float DistanceBetweenPoints(Vector3 point1, Vector3 point2);
            
        int SpellBuffCount(IUnit target, string buffName, IUnit caster);

        float BBLuaGetGold(IUnit target, float delta);

        TeamID GetTeamID(IUnit target);

        float GetTime();

        string GetUnitSkinName(IUnit target);

        bool HasBuff(IUnit owner, string buffName, IUnit attacker);

        bool HasBuffOfType(IUnit target, BuffType buffType);

        bool HasPARType(IUnit owner, PARType parType);

        void IssueOrder(IUnit whom, Order order, IUnit target);

        void ReincarnateNonDeadHero(IUnit target);

        void SetCanCastWhileDisabled(bool canCast);

        void SetScaleSkinCoef(float scale, IUnit owner);

        void SetSlotSpellCooldownTime(IUnit owner, float src, SpellSlot slot);

        void SetSpellCastRange(float range);

        void SpellBuffRemoveStacks(IUnit target, string buffName, IUnit attacker, int numStacks);

        void BBTeleportToPoint(IUnit owner, Vector3 position);
    }
}
