using System;
using System.Numerics;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBFunction
    {
        public sealed class BBApplyDamage : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out bool ignoreDamageIncreaseMods, "IgnoreDamageIncreaseMods");
                p.GetBBParam(out bool ignoreDamageCrit, "IgnoreDamageCrit");
                p.GetBBParam(out HitResult hitResult, "HitResult");
                p.GetBBParam(out float damage, "Damage", require: true);
                p.GetBBParam(out float percentOfAttack, "PercentOfAttack", require: true);
                p.GetBBParam(out GObjID attacker, "Attacker", require: true);
                p.GetBBParam(out GObjID callForHelpAttacker, "CallForHelpAttacker");
                var damageType = p.GetInBlock("DamageType").AsEnum<DamageTypes>().Default();
                var sourceDamageType = p.GetInBlock("SourceDamageType").AsEnum<DamageSource>().Default();
                p.GetBBParam(out float spellDamageRatio, "SpellDamageRatio", @default: 1.0f);
                p.GetBBParam(out float physicalDamageRatio, "PhysicalDamageRatio", @default: 1.0f);
                c.BBApplyDamage(
                    target: target,
                    ignoreDamageIncreaseMods: ignoreDamageIncreaseMods,
                    ignoreDamageCrit: ignoreDamageCrit,
                    hitResult: hitResult,
                    damage: damage,
                    percentOfAttack: percentOfAttack,
                    attacker: attacker,
                    callForHelpAttacker: callForHelpAttacker,
                    damageType: damageType,
                    sourceDamageType: sourceDamageType,
                    spellDamageRatio: spellDamageRatio,
                    physicalDamageRatio: physicalDamageRatio
                    );
                return 0;
            }
        }
    }
}