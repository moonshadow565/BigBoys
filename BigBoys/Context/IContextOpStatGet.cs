using System;
using BigBoys.Execution;
using BigBoys.Lua;

namespace BigBoys.Context
{
    public partial interface IContext
    {
        float GetAcquisitionRangeMod(IUnit target);
        float GetArmor(IUnit target);
        float GetAttackSpeedMod(IUnit target);
        float GetBaseAttackDamage(IUnit target);
        float GetDodge(IUnit target);
        float GetFlatArmorMod(IUnit target);
        float GetFlatArmorPenetrationMod(IUnit target);
        float GetFlatAttackRangeMod(IUnit target);
        float GetFlatBubbleRadiusMod(IUnit target);
        float GetFlatCastRangeMod(IUnit target);
        float GetFlatCooldownMod(IUnit target);
        float GetFlatCritChanceMod(IUnit target);
        float GetFlatCritDamageMod(IUnit target);
        float GetFlatGoldPer10Mod(IUnit target);
        float GetFlatHPPoolMod(IUnit target);
        float GetFlatHPRegenMod(IUnit target);
        float GetFlatMagicDamageMod(IUnit target);
        float GetFlatMagicPenetrationMod(IUnit target);
        float GetFlatMagicReduction(IUnit target);
        float GetFlatMovementSpeedMod(IUnit target);
        float GetFlatPhysicalDamageMod(IUnit target);
        float GetFlatPhysicalReduction(IUnit target);
        float GetFlatSpellBlockMod(IUnit target);
        float GetLevel(IUnit target);
        float GetMissChance(IUnit target);
        float GetMovementSpeed(IUnit target);
        float GetPercentAttackRangeMod(IUnit target);
        float GetPercentAttackSpeedMod(IUnit target);
        float GetPercentBubbleRadiusMod(IUnit target);
        float GetPercentCastRangeMod(IUnit target);
        float GetPercentCooldownMod(IUnit target);
        float GetPercentCritDamageMod(IUnit target);
        float GetPercentEXPBonus(IUnit target);
        float GetPercentGoldLostOnDeathMod(IUnit target);
        float GetPercentHPPoolMod(IUnit target);
        float GetPercentHPRegenMod(IUnit target);
        float GetPercentHardnessMod(IUnit target);
        float GetPercentHealingAmountMod(IUnit target);
        float GetPercentLifeStealMod(IUnit target);
        float GetPercentMagicDamageMod(IUnit target);
        float GetPercentMagicReduction(IUnit target);
        float GetPercentMovementSpeedMod(IUnit target);
        float GetPercentPhysicalDamageMod(IUnit target);
        float GetPercentPhysicalReduction(IUnit target);
        float GetPercentRespawnTimeMod(IUnit target);
        float GetPercentSpellBlockMod(IUnit target);
        float GetPercentSpellVampMod(IUnit target);
        float GetSpellBlock(IUnit target);
        float GetTotalAttackDamage(IUnit target);
    }
}
