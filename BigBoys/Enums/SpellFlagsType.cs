using System;
namespace BigBoys.Enums
{
    [Flags]
    public enum SpellFlagsType
    {
        Autocast = 0x2,
        Instacast = 0x4,
        PersistThroughDeath = 0x8,
        NonDispellable = 0x10,
        NoClick = 0x20,
        AffectEnemies = 0x400,
        AffectFriends = 0x800,
        AffectNeutral = 0x4000,
        AffectsAllSides = 0x4C00,
        AffectUntargetable = 0x200,
        AffectBuildings = 0x1000,
        AffectMinions = 0x8000,
        AffectHeroes = 0x10000,
        AffectTurrets = 0x20000,
        AffectsAllUnitTypes = 0x38000,
        AffectNotPet = 0x100000,
        NotAffectSelf = 0x2000,
        AlwaysSelf = 0x40000,
        AffectDead = 0x80000,
        AffectBarrackOnly = 0x200000,
        IgnoreVisibilityCheck = 0x400000,
        NonTargetableAlly = 0x800000,
        NonTargetableEnemy = 0x1000000,
        TargetableToAll = 0x2000000,
        NonTargetableAll = 0x1800000,
        AffectWards = 0x4000000,
        AffectUseable = 0x8000000,
    }
}
