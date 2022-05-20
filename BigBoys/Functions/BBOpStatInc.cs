using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract class BBOpStatInc
    {
        private BBOpStatInc() {}
        
        public abstract void Call(IContext c, float delta, IUnit target);

        public sealed class IncAcquisitionRangeMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncAcquisitionRangeMod(delta, target);
        }

        public sealed class IncBaseAttackDamage : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncBaseAttackDamage(delta, target);
        }

        public sealed class IncFlatArmorMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatArmorMod(delta, target);
        }

        public sealed class IncFlatArmorPenetrationMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatArmorPenetrationMod(delta, target);
        }

        public sealed class IncFlatAttackRangeMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatAttackRangeMod(delta, target);
        }

        public sealed class IncFlatBubbleRadiusMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatBubbleRadiusMod(delta, target);
        }

        public sealed class IncFlatCastRangeMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatCastRangeMod(delta, target);
        }

        public sealed class IncFlatCooldownMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatCooldownMod(delta, target);
        }

        public sealed class IncFlatCritChanceMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatCritChanceMod(delta, target);
        }

        public sealed class IncFlatCritDamageMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatCritDamageMod(delta, target);
        }

        public sealed class IncFlatDodgeMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatDodgeMod(delta, target);
        }

        public sealed class IncFlatGoldPer10Mod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatGoldPer10Mod(delta, target);
        }

        public sealed class IncFlatHPPoolMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatHPPoolMod(delta, target);
        }

        public sealed class IncFlatHPRegenMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatHPRegenMod(delta, target);
        }

        public sealed class IncFlatMagicDamageMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatMagicDamageMod(delta, target);
        }

        public sealed class IncFlatMagicPenetrationMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatMagicPenetrationMod(delta, target);
        }

        public sealed class IncFlatMagicReduction : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatMagicReduction(delta, target);
        }

        public sealed class IncFlatMissChanceMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatMissChanceMod(delta, target);
        }

        public sealed class IncFlatMovementSpeedMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatMovementSpeedMod(delta, target);
        }

        public sealed class IncFlatPhysicalDamageMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatPhysicalDamageMod(delta, target);
        }

        public sealed class IncFlatPhysicalReduction : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatPhysicalReduction(delta, target);
        }

        public sealed class IncFlatSpellBlockMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncFlatSpellBlockMod(delta, target);
        }

        public sealed class IncHealth : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncHealth(delta, target);
        }

        public sealed class IncMana : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncMana(delta, target);
        }

        public sealed class IncMoveSpeedFloorMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncMoveSpeedFloorMod(delta, target);
        }

        public sealed class IncPercentArmorMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentArmorMod(delta, target);
        }

        public sealed class IncPercentArmorPenetrationMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentArmorPenetrationMod(delta, target);
        }

        public sealed class IncPercentAttackRangeMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentAttackRangeMod(delta, target);
        }

        public sealed class IncPercentAttackSpeedMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentAttackSpeedMod(delta, target);
        }

        public sealed class IncPercentBubbleRadiusMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentBubbleRadiusMod(delta, target);
        }

        public sealed class IncPercentCastRangeMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentCastRangeMod(delta, target);
        }

        public sealed class IncPercentCooldownMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentCooldownMod(delta, target);
        }

        public sealed class IncPercentCritDamageMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentCritDamageMod(delta, target);
        }

        public sealed class IncPercentEXPBonus : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentEXPBonus(delta, target);
        }

        public sealed class IncPercentGoldLostOnDeathMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentGoldLostOnDeathMod(delta, target);
        }

        public sealed class IncPercentHardnessMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentHardnessMod(delta, target);
        }

        public sealed class IncPercentHealingAmountMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentHealingAmountMod(delta, target);
        }

        public sealed class IncPercentHPPoolMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentHPPoolMod(delta, target);
        }

        public sealed class IncPercentHPRegenMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentHPRegenMod(delta, target);
        }

        public sealed class IncPercentLifeStealMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentLifeStealMod(delta, target);
        }

        public sealed class IncPercentMagicDamageMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentMagicDamageMod(delta, target);
        }

        public sealed class IncPercentMagicPenetrationMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentMagicPenetrationMod(delta, target);
        }

        public sealed class IncPercentMagicReduction : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentMagicReduction(delta, target);
        }

        public sealed class IncPercentMovementSpeedMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentMovementSpeedMod(delta, target);
        }

        public sealed class IncPercentMultiplicativeAttackSpeedMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentMultiplicativeAttackSpeedMod(delta, target);
        }

        public sealed class IncPercentMultiplicativeMovementSpeedMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentMultiplicativeMovementSpeedMod(delta, target);
        }

        public sealed class IncPercentPhysicalDamageMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentPhysicalDamageMod(delta, target);
        }

        public sealed class IncPercentPhysicalReduction : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentPhysicalReduction(delta, target);
        }

        public sealed class IncPercentRespawnTimeMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentRespawnTimeMod(delta, target);
        }

        public sealed class IncPercentSpellBlockMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentSpellBlockMod(delta, target);
        }

        public sealed class IncPercentSpellVampMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPercentSpellVampMod(delta, target);
        }

        public sealed class IncPermanentAcquisitionRangeMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentAcquisitionRangeMod(delta, target);
        }

        public sealed class IncPermanentBaseAttackDamage : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentBaseAttackDamage(delta, target);
        }

        public sealed class IncPermanentFlatArmorMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatArmorMod(delta, target);
        }

        public sealed class IncPermanentFlatArmorPenetrationMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatArmorPenetrationMod(delta, target);
        }

        public sealed class IncPermanentFlatAttackRangeMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatAttackRangeMod(delta, target);
        }

        public sealed class IncPermanentFlatBubbleRadiusMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatBubbleRadiusMod(delta, target);
        }

        public sealed class IncPermanentFlatCastRangeMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatCastRangeMod(delta, target);
        }

        public sealed class IncPermanentFlatCooldownMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatCooldownMod(delta, target);
        }

        public sealed class IncPermanentFlatCritChanceMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatCritChanceMod(delta, target);
        }

        public sealed class IncPermanentFlatCritDamageMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatCritDamageMod(delta, target);
        }

        public sealed class IncPermanentFlatGoldPer10Mod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatGoldPer10Mod(delta, target);
        }

        public sealed class IncPermanentFlatHPPoolMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatHPPoolMod(delta, target);
        }

        public sealed class IncPermanentFlatHPRegenMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatHPRegenMod(delta, target);
        }

        public sealed class IncPermanentFlatMagicDamageMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatMagicDamageMod(delta, target);
        }

        public sealed class IncPermanentFlatMagicPenetrationMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatMagicPenetrationMod(delta, target);
        }

        public sealed class IncPermanentFlatMagicReduction : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatMagicReduction(delta, target);
        }

        public sealed class IncPermanentFlatMovementSpeedMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatMovementSpeedMod(delta, target);
        }

        public sealed class IncPermanentFlatPhysicalDamageMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatPhysicalDamageMod(delta, target);
        }

        public sealed class IncPermanentFlatPhysicalReduction : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatPhysicalReduction(delta, target);
        }

        public sealed class IncPermanentFlatSpellBlockMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentFlatSpellBlockMod(delta, target);
        }

        public sealed class IncPermanentPercentAttackRangeMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentAttackRangeMod(delta, target);
        }

        public sealed class IncPermanentPercentAttackSpeedMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentAttackSpeedMod(delta, target);
        }

        public sealed class IncPermanentPercentBubbleRadiusMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentBubbleRadiusMod(delta, target);
        }

        public sealed class IncPermanentPercentCastRangeMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentCastRangeMod(delta, target);
        }

        public sealed class IncPermanentPercentCooldownMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentCooldownMod(delta, target);
        }

        public sealed class IncPermanentPercentCritDamageMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentCritDamageMod(delta, target);
        }

        public sealed class IncPermanentPercentEXPBonus : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentEXPBonus(delta, target);
        }

        public sealed class IncPermanentPercentGoldLostOnDeathMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentGoldLostOnDeathMod(delta, target);
        }

        public sealed class IncPermanentPercentHardnessMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentHardnessMod(delta, target);
        }

        public sealed class IncPermanentPercentHealingAmountMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentHealingAmountMod(delta, target);
        }

        public sealed class IncPermanentPercentHPPoolMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentHPPoolMod(delta, target);
        }

        public sealed class IncPermanentPercentHPRegenMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentHPRegenMod(delta, target);
        }

        public sealed class IncPermanentPercentLifeStealMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentLifeStealMod(delta, target);
        }

        public sealed class IncPermanentPercentMagicDamageMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentMagicDamageMod(delta, target);
        }

        public sealed class IncPermanentPercentMagicReduction : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentMagicReduction(delta, target);
        }

        public sealed class IncPermanentPercentMovementSpeedMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentMovementSpeedMod(delta, target);
        }

        public sealed class IncPermanentPercentPhysicalDamageMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentPhysicalDamageMod(delta, target);
        }

        public sealed class IncPermanentPercentPhysicalReduction : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentPhysicalReduction(delta, target);
        }

        public sealed class IncPermanentPercentRespawnTimeMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentRespawnTimeMod(delta, target);
        }

        public sealed class IncPermanentPercentSpellBlockMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentSpellBlockMod(delta, target);
        }

        public sealed class IncPermanentPercentSpellVampMod : BBOpStatInc
        {
            public override void Call(IContext c, float delta, IUnit target) => c.IncPermanentPercentSpellVampMod(delta, target);
        }
    }
}
