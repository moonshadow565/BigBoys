using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract class BBOpStatGet
    {
        private BBOpStatGet() {}
        
        public abstract float Call(IContext c, IUnit target);

        public sealed class GetAcquisitionRangeMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetAcquisitionRangeMod(target);
        }

        public sealed class GetArmor : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetArmor(target);
        }

        public sealed class GetAttackSpeedMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetAttackSpeedMod(target);
        }

        public sealed class GetBaseAttackDamage : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetBaseAttackDamage(target);
        }

        public sealed class GetDodge : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetDodge(target);
        }

        public sealed class GetFlatArmorMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatArmorMod(target);
        }

        public sealed class GetFlatArmorPenetrationMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatArmorPenetrationMod(target);
        }

        public sealed class GetFlatAttackRangeMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatAttackRangeMod(target);
        }

        public sealed class GetFlatBubbleRadiusMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatBubbleRadiusMod(target);
        }

        public sealed class GetFlatCastRangeMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatCastRangeMod(target);
        }

        public sealed class GetFlatCooldownMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatCooldownMod(target);
        }

        public sealed class GetFlatCritChanceMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatCritChanceMod(target);
        }

        public sealed class GetFlatCritDamageMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatCritDamageMod(target);
        }

        public sealed class GetFlatGoldPer10Mod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatGoldPer10Mod(target);
        }

        public sealed class GetFlatHPPoolMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatHPPoolMod(target);
        }

        public sealed class GetFlatHPRegenMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatHPRegenMod(target);
        }

        public sealed class GetFlatMagicDamageMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatMagicDamageMod(target);
        }

        public sealed class GetFlatMagicPenetrationMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatMagicPenetrationMod(target);
        }

        public sealed class GetFlatMagicReduction : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatMagicReduction(target);
        }

        public sealed class GetFlatMovementSpeedMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatMovementSpeedMod(target);
        }

        public sealed class GetFlatPhysicalDamageMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatPhysicalDamageMod(target);
        }

        public sealed class GetFlatPhysicalReduction : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatPhysicalReduction(target);
        }

        public sealed class GetFlatSpellBlockMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetFlatSpellBlockMod(target);
        }

        public sealed class GetLevel : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetLevel(target);
        }

        public sealed class GetMissChance : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetMissChance(target);
        }

        public sealed class GetMovementSpeed : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetMovementSpeed(target);
        }

        public sealed class GetPercentAttackRangeMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentAttackRangeMod(target);
        }

        public sealed class GetPercentAttackSpeedMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentAttackSpeedMod(target);
        }

        public sealed class GetPercentBubbleRadiusMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentBubbleRadiusMod(target);
        }

        public sealed class GetPercentCastRangeMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentCastRangeMod(target);
        }

        public sealed class GetPercentCooldownMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentCooldownMod(target);
        }

        public sealed class GetPercentCritDamageMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentCritDamageMod(target);
        }

        public sealed class GetPercentEXPBonus : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentEXPBonus(target);
        }

        public sealed class GetPercentGoldLostOnDeathMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentGoldLostOnDeathMod(target);
        }

        public sealed class GetPercentHardnessMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentHardnessMod(target);
        }

        public sealed class GetPercentHealingAmountMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentHealingAmountMod(target);
        }

        public sealed class GetPercentHPPoolMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentHPPoolMod(target);
        }

        public sealed class GetPercentHPRegenMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentHPRegenMod(target);
        }

        public sealed class GetPercentLifeStealMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentLifeStealMod(target);
        }

        public sealed class GetPercentMagicDamageMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentMagicDamageMod(target);
        }

        public sealed class GetPercentMagicReduction : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentMagicReduction(target);
        }

        public sealed class GetPercentMovementSpeedMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentMovementSpeedMod(target);
        }

        public sealed class GetPercentPhysicalDamageMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentPhysicalDamageMod(target);
        }

        public sealed class GetPercentPhysicalReduction : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentPhysicalReduction(target);
        }

        public sealed class GetPercentRespawnTimeMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentRespawnTimeMod(target);
        }

        public sealed class GetPercentSpellBlockMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentSpellBlockMod(target);
        }

        public sealed class GetPercentSpellVampMod : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetPercentSpellVampMod(target);
        }

        public sealed class GetSpellBlock : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetSpellBlock(target);
        }

        public sealed class GetTotalAttackDamage : BBOpStatGet
        {
            public override float Call(IContext c, IUnit target) => c.GetTotalAttackDamage(target);
        }
    }
}
