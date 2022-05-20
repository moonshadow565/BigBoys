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
        private BBFunction() {}
        
        public abstract int Call(IContext c, Params p);

        public sealed class BBAddDebugCircle : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit");
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float radius, "Radius", require: true);
                p.GetBBParam(out int colorR, "ColorR", require: true);
                p.GetBBParam(out int colorG, "ColorG", require: true);
                p.GetBBParam(out int colorB, "ColorB", require: true);
                p.GetBBParam(out int colorA, "ColorA", require: true);
                var result = c.BBAddDebugCircle(
                    unit: unit,
                    center: center,
                    radius: radius,
                    colorR: colorR,
                    colorG: colorG,
                    colorB: colorB,
                    colorA: colorA
                );
                p.SetBBParam("DebugCircleID", result);
                return 0;
            }
        }

        public sealed class BBAddPosPerceptionBubble : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float radius, "Radius", require: true);
                p.GetBBParam(out Vector3 pos, "Pos", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out TeamID team, "Team");
                p.GetBBParam(out IUnit specificUnitsClientOnly, "SpecificUnitsClientOnly");
                p.GetBBParam(out bool revealSteath, "RevealSteath", require: true);
                p.GetBBParam(out IUnit revealSpecificUnitOnly, "RevealSpecificUnitOnly");
                var result = c.BBAddPosPerceptionBubble(
                    radius: radius,
                    pos: pos,
                    duration: duration,
                    team: team,
                    specificUnitsClientOnly: specificUnitsClientOnly,
                    revealSteath: revealSteath,
                    revealSpecificUnitOnly: revealSpecificUnitOnly
                    );
                p.SetBBParam("BubbleID", result);
                return 0;
            }
        }

        public sealed class BBAddUnitPerceptionBubble : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float radius, "Radius", require: true);
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out TeamID team, "Team");
                p.GetBBParam(out IUnit specificUnitsClientOnly, "SpecificUnitsClientOnly");
                p.GetBBParam(out bool revealSteath, "RevealSteath", require: true);
                p.GetBBParam(out IUnit revealSpecificUnitOnly, "RevealSpecificUnitOnly");
                var result = c.BBAddUnitPerceptionBubble(
                    radius: radius,
                    target: target,
                    duration: duration,
                    team: team,
                    specificUnitsClientOnly: specificUnitsClientOnly,
                    revealSteath: revealSteath,
                    revealSpecificUnitOnly: revealSpecificUnitOnly
                    );
                p.SetBBParam("BubbleID", result);
                return 0;
            }
        }

        public sealed class BBAdjustCastInfoCenterAOE : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var owner = p.GetInPass("Owner").AsUnit().Require();
                p.GetBBParam(out float radius, "Radius", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                c.BBAdjustCastInfoCenterAOE(
                    owner: owner,
                    radius: radius,
                    flags: flags
                    );
                return 0;
            }
        }

        public sealed class BBApplyAssistMarker : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out IUnit source, "Source", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                c.BBApplyAssistMarker(
                    target: target,
                    source: source,
                    duration: duration
                    );
                return 0;
            }
        }

        public sealed class BBApplyBrushCircle : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 pos, "Pos", require: true);
                p.GetBBParam(out float radius, "Radius", require: true);
                var result = c.BBApplyBrushCircle(
                    pos: pos,
                    radius: radius
                    );
                p.SetBBParam("ID", result);
                return 0;
            }
        }

        public sealed class BBApplyCallForHelpSuppresser : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyCallForHelpSuppresser(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplyCharm : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyCharm(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

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

        public sealed class BBApplyDisarm : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyDisarm(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplyFear : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyFear(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplyForceRenderParticles : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyForceRenderParticles(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplyIgnoreCallForHelp : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyIgnoreCallForHelp(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplyNearSight : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyNearSight(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplyNet : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyNet(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplyNoRender : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyNoRender(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplyPacified : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyPacified(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplyRevealSpecificUnit : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyRevealSpecificUnit(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplyRoot : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyRoot(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplySilence : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplySilence(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplySleep : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplySleep(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplyStealth : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyStealth(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplyStun : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyStun(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplySuppressCallForHelp : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplySuppressCallForHelp(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplySuppression : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplySuppression(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBApplyTaunt : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                c.BBApplyTaunt(
                    target: target,
                    duration: duration,
                    attacker: attacker
                    );
                return 0;
            }
        }

        public sealed class BBCancelAutoAttack : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out bool reset, "Reset");
                c.BBCancelAutoAttack(
                    target: target,
                    reset: reset
                    );
                return 0;
            }
        }

        public sealed class BBCanSeeTarget : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit viewer, "Viewer", require: true);
                p.GetBBParam(out IUnit target, "Target", require: true);
                var result = c.BBCanSeeTarget(
                    viewer: viewer,
                    target: target
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }

        public sealed class BBClearOverrideAnimation : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out string toOverrideAnim, "ToOverrideAnim", require: true);
                c.BBClearOverrideAnimation(
                    owner: owner,
                    toOverrideAnim: toOverrideAnim
                    );
                return 0;
            }
        }

        public sealed class BBClearPARColorOverride : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit spellSlotOwner, "SpellSlotOwner", require: true);
                c.BBClearPARColorOverride(
                    spellSlotOwner: spellSlotOwner
                    );
                return 0;
            }
        }

        public sealed class BBCloneUnitPet : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unitToClone, "UnitToClone", require: true);
                p.GetBBParam(out Vector3 pos, "Pos", require: true);
                p.GetBBParam(out IUnit goldRedirectTarget, "GoldRedirectTarget");
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out bool copyItems, "CopyItems", @default: true);
                p.GetBBParam(out bool showMinimapIcon, "ShowMinimapIcon", @default: true);
                p.GetBBParam(out int level, "Level", require: true);
                p.GetBBParam(out int healthBonus, "HealthBonus", require: true);
                p.GetBBParam(out int damageBonus, "DamageBonus", require: true);
                p.GetBBParam(out string buff, "Buff", require: true);
                p.GetBBParam(out string aiScript, "AiScript", @default: "Pet.lua");
                var result = c.BBCloneUnitPet(
                    unitToClone: unitToClone,
                    pos: pos,
                    goldRedirectTarget: goldRedirectTarget,
                    owner: owner,
                    duration: duration,
                    copyItems: copyItems,
                    showMinimapIcon: showMinimapIcon,
                    level: level,
                    healthBonus: healthBonus,
                    damageBonus: damageBonus,
                    buff: buff,
                    aiScript: aiScript
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }

        public sealed class BBCreateItem : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                p.GetBBParam(out int itemID, "ItemID", require: true);
                c.BBCreateItem(
                    unit: unit,
                    itemID: itemID
                    );
                return 0;
            }
        }

        public sealed class BBDestroyMissile : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out int missileID, "MissileID", require: true);
                c.BBDestroyMissile(
                    missileID: missileID
                    );
                return 0;
            }
        }

        public sealed class BBDestroyMissileForTarget : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBDestroyMissileForTarget(
                    target: target
                    );
                return 0;
            }
        }

        public sealed class BBDispellNegativeBuffs : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBDispellNegativeBuffs(
                    target: target
                    );
                return 0;
            }
        }

        public sealed class BBDispellPositiveBuffs : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBDispellPositiveBuffs(
                    target: target
                    );
                return 0;
            }
        }

        public sealed class BBEnableWallOfGrassTracking : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                p.GetBBParam(out bool enable, "Enable", require: true);
                c.BBEnableWallOfGrassTracking(
                    unit: unit,
                    enable: enable
                    );
                return 0;
            }
        }

        public sealed class BBFaceDirection : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out Vector3 location, "Location", require: true);
                c.BBFaceDirection(
                    target: target,
                    location: location
                    );
                return 0;
            }
        }

        public sealed class BBFadeInColorFadeEffect : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out int colorRed, "ColorRed", require: true);
                p.GetBBParam(out int colorGreen, "ColorGreen", require: true);
                p.GetBBParam(out int colorBlue, "ColorBlue", require: true);
                p.GetBBParam(out float fadeTime, "FadeTime", require: true);
                p.GetBBParam(out float maxWeight, "MaxWeight", require: true);
                p.GetBBParam(out TeamID specificToTeam, "SpecificToTeam", require: true);
                c.BBFadeInColorFadeEffect(
                    colorRed: colorRed,
                    colorGreen: colorGreen,
                    colorBlue: colorBlue,
                    fadeTime: fadeTime,
                    maxWeight: maxWeight,
                    specificToTeam: specificToTeam
                    );
                return 0;
            }
        }

        public sealed class BBFadeOutColorFadeEffect : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float fadeTime, "FadeTime", require: true);
                p.GetBBParam(out TeamID specificToTeam, "SpecificToTeam", require: true);
                c.BBFadeOutColorFadeEffect(
                    fadeTime: fadeTime,
                    specificToTeam: specificToTeam
                    );
                return 0;
            }
        }

        public sealed class BBForceDead : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                c.BBForceDead(
                    owner: owner
                    );
                return 0;
            }
        }

        public sealed class BBForceRefreshPath : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                c.BBForceRefreshPath(
                    unit: unit
                    );
                return 0;
            }
        }

        public sealed class BBForEachChampion : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string iterator, "IteratorVar", @default: "Owner");
                p.GetBBParam(out TeamID team, "Team", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                var result = c.BBForEachChampion(
                    team: team,
                    buffNameFilter: buffNameFilter,
                    inclusiveBuffFilter: inclusiveBuffFilter
                    );
                var old = p.PassThrough[iterator];
                try
                {
                    foreach (var i in result)
                    {
                        p.PassThrough[iterator] = i;
                        p.Exec(c);
                    }
                }
                catch (BreakLoop) { }
                p.PassThrough[iterator] = old;
                return 0;
            }
        }

        public sealed class BBForEachPetInTarget : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string iterator, "IteratorVar", @default: "Owner");
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                var result = c.BBForEachPetInTarget(
                    target: target,
                    buffNameFilter: buffNameFilter,
                    inclusiveBuffFilter: inclusiveBuffFilter
                    );
                var old = p.PassThrough[iterator];
                try
                {
                    foreach (var i in result)
                    {
                        p.PassThrough[iterator] = i;
                        p.Exec(c);
                    }
                }
                catch (BreakLoop) { }
                p.PassThrough[iterator] = old;
                return 0;
            }
        }

        public sealed class BBForEachPointAroundCircle : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float radius, "Radius", require: true);
                p.GetBBParam(out int iterations, "Iterations", require: true);
                var result = c.BBForEachPointAroundCircle(
                    center: center,
                    radius: radius,
                    iterations: iterations
                    );
                try
                {
                    foreach (var i in result)
                    {
                        p.SetBBParam("Iterator", i);
                        p.Exec(c);
                    }
                }
                catch (BreakLoop) { }
                return 0;
            }
        }

        public sealed class BBForEachPointOnLine : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out Vector3 faceTowardsPos, "FaceTowardsPos", require: true);
                p.GetBBParam(out float size, "Size", require: true);
                p.GetBBParam(out float pushForward, "PushForward", require: true);
                p.GetBBParam(out int iterations, "Iterations", require: true);
                var result = c.BBForEachPointOnLine(
                    center: center,
                    faceTowardsPos: faceTowardsPos,
                    size: size,
                    pushForward: pushForward,
                    iterations: iterations
                    );
                try
                {
                    foreach (var i in result)
                    {
                        p.SetBBParam("Iterator", i);
                        p.Exec(c);
                    }
                }
                catch (BreakLoop) { }
                return 0;
            }
        }

        public sealed class BBForEachUnitInTargetArea : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string iterator, "IteratorVar", @default: "Owner");
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float range, "Range", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                var result = c.BBForEachUnitInTargetArea(
                    attacker: attacker,
                    center: center,
                    range: range,
                    flags: flags,
                    buffNameFilter: buffNameFilter,
                    inclusiveBuffFilter: inclusiveBuffFilter
                    );
                var old = p.PassThrough[iterator];
                try
                {
                    foreach (var i in result)
                    {
                        p.PassThrough[iterator] = i;
                        p.Exec(c);
                    }
                }
                catch (BreakLoop) { }
                p.PassThrough[iterator] = old;
                return 0;
            }
        }

        public sealed class BBForEachUnitInTargetAreaAddBuff : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float range, "Range", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                p.GetBBParam(out IUnit buffAttacker, "BuffAttacker", require: true);
                p.GetBBParam(out int buffNumberOfStacks, "BuffNumberOfStacks", @default: 1);
                p.GetBBParam(out float buffDuration, "BuffDuration", require: true);
                p.GetBBParam(out BuffAddType buffAddType, "BuffAddType", require: true);
                p.GetBBParam(out int tickRate, "TickRate", require: true);
                p.GetBBParam(out bool isHiddenOnClient, "IsHiddenOnClient");
                var buffName = p.GetInBlock("BuffName").AsString().Require();
                p.GetBBParam(out int buffMaxStack, "BuffMaxStack", require: true);
                var buffType = p.GetInBlock("BuffType").AsEnum<BuffType>().Require();
                var buffVars = p.GetInVarOrPass("BuffVarsTable", "NextBuffVar").AsTable() ?? new Table();
                c.BBForEachUnitInTargetAreaAddBuff(
                    attacker: attacker,
                    center: center,
                    range: range,
                    flags: flags,
                    buffNameFilter: buffNameFilter,
                    inclusiveBuffFilter: inclusiveBuffFilter,
                    buffAttacker: buffAttacker,
                    buffNumberOfStacks: buffNumberOfStacks,
                    buffDuration: buffDuration,
                    buffAddType: buffAddType,
                    tickRate: tickRate,
                    isHiddenOnClient: isHiddenOnClient,
                    buffName: buffName,
                    buffMaxStack: buffMaxStack,
                    buffType: buffType,
                    buffVars: buffVars
                    );
                return 0;
            }
        }

        public sealed class BBForEachUnitInTargetAreaRandom : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string iterator, "IteratorVar", @default: "Owner");
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float range, "Range", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                p.GetBBParam(out int maximumUnitsToPick, "MaximumUnitsToPick", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                var result = c.BBForEachUnitInTargetAreaRandom(
                    attacker: attacker,
                    center: center,
                    range: range,
                    flags: flags,
                    maximumUnitsToPick: maximumUnitsToPick,
                    buffNameFilter: buffNameFilter,
                    inclusiveBuffFilter: inclusiveBuffFilter
                    );
                var old = p.PassThrough[iterator];
                try
                {
                    foreach (var i in result)
                    {
                        p.PassThrough[iterator] = i;
                        p.Exec(c);
                    }
                }
                catch (BreakLoop) { }
                p.PassThrough[iterator] = old;
                return 0;
            }
        }

        public sealed class BBForEachUnitInTargetRectangle : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string iterator, "IteratorVar", @default: "Owner");
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float halfWidth, "HalfWidthg", require: true);
                p.GetBBParam(out float halfLength, "HalfLength", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                var result = c.BBForEachUnitInTargetRectangle(
                    attacker: attacker,
                    center: center,
                    halfWidth: halfWidth,
                    halfLength: halfLength,
                    flags: flags,
                    buffNameFilter: buffNameFilter,
                    inclusiveBuffFilter: inclusiveBuffFilter
                    );
                var old = p.PassThrough[iterator];
                try
                {
                    foreach (var i in result)
                    {
                        p.PassThrough[iterator] = i;
                        p.Exec(c);
                    }
                }
                catch (BreakLoop) { }
                p.PassThrough[iterator] = old;
                return 0;
            }
        }

        public sealed class BBForEachVisibleUnitInTargetArea : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string iterator, "IteratorVar", @default: "Owner");
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float range, "Range", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                var result = c.BBForEachVisibleUnitInTargetArea(
                    attacker: attacker,
                    center: center,
                    range: range,
                    flags: flags,
                    buffNameFilter: buffNameFilter,
                    inclusiveBuffFilter: inclusiveBuffFilter
                    );
                var old = p.PassThrough[iterator];
                try
                {
                    foreach (var i in result)
                    {
                        p.PassThrough[iterator] = i;
                        p.Exec(c);
                    }
                }
                catch (BreakLoop) { }
                p.PassThrough[iterator] = old;
                return 0;
            }
        }

        public sealed class BBForEachVisibleUnitInTargetAreaAddBuff : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float range, "Range", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                p.GetBBParam(out IUnit buffAttacker, "BuffAttacker", require: true);
                p.GetBBParam(out int buffNumberOfStacks, "BuffNumberOfStacks", @default: 1);
                p.GetBBParam(out float buffDuration, "BuffDuration", require: true);
                p.GetBBParam(out BuffAddType buffAddType, "BuffAddType", require: true);
                p.GetBBParam(out int tickRate, "TickRate", require: true);
                p.GetBBParam(out bool isHiddenOnClient, "IsHiddenOnClient");
                var buffName = p.GetInBlock("BuffName").AsString().Require();
                p.GetBBParam(out int buffMaxStack, "BuffMaxStack", require: true);
                var buffType = p.GetInBlock("BuffType").AsEnum<BuffType>().Require();
                var buffVars = p.GetInVarOrPass("BuffVarsTable", "NextBuffVar").AsTable() ?? new Table();
                c.BBForEachVisibleUnitInTargetAreaAddBuff(
                    attacker: attacker,
                    center: center,
                    range: range,
                    flags: flags,
                    buffNameFilter: buffNameFilter,
                    inclusiveBuffFilter: inclusiveBuffFilter,
                    buffAttacker: buffAttacker,
                    buffNumberOfStacks: buffNumberOfStacks,
                    buffDuration: buffDuration,
                    buffAddType: buffAddType,
                    tickRate: tickRate,
                    isHiddenOnClient: isHiddenOnClient,
                    buffName: buffName,
                    buffMaxStack: buffMaxStack,
                    buffType: buffType,
                    buffVars: buffVars
                    );
                return 0;
            }
        }

        public sealed class BBForEachVisibleUnitInTargetAreaRandom : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string iterator, "IteratorVar", @default: "Owner");
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float range, "Range", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                p.GetBBParam(out int maximumUnitsToPick, "MaximumUnitsToPick", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                var result = c.BBForEachVisibleUnitInTargetAreaRandom(
                    attacker: attacker,
                    center: center,
                    range: range,
                    flags: flags,
                    maximumUnitsToPick: maximumUnitsToPick,
                    buffNameFilter: buffNameFilter,
                    inclusiveBuffFilter: inclusiveBuffFilter
                    );
                var old = p.PassThrough[iterator];
                try
                {
                    foreach (var i in result)
                    {
                        p.PassThrough[iterator] = i;
                        p.Exec(c);
                    }
                }
                catch (BreakLoop) { }
                p.PassThrough[iterator] = old;
                return 0;
            }
        }

        public sealed class BBForEachVisibleUnitInTargetRectangle : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string iterator, "IteratorVar", @default: "Owner");
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float halfWidth, "HalfWidthg", require: true);
                p.GetBBParam(out float halfLength, "HalfLength", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                var result = c.BBForEachVisibleUnitInTargetRectangle(
                    attacker: attacker,
                    center: center,
                    halfWidth: halfWidth,
                    halfLength: halfLength,
                    flags: flags,
                    buffNameFilter: buffNameFilter,
                    inclusiveBuffFilter: inclusiveBuffFilter
                    );
                var old = p.PassThrough[iterator];
                try
                {
                    foreach (var i in result)
                    {
                        p.PassThrough[iterator] = i;
                        p.Exec(c);
                    }
                }
                catch (BreakLoop) { }
                p.PassThrough[iterator] = old;
                return 0;
            }
        }

        public sealed class BBForNClosestUnitsInTargetArea : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string iterator, "IteratorVar", @default: "Owner");
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float range, "Range", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                p.GetBBParam(out int maximumUnitsToPick, "MaximumUnitsToPick", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                var result = c.BBForNClosestUnitsInTargetArea(
                    attacker: attacker,
                    center: center,
                    range: range,
                    flags: flags,
                    maximumUnitsToPick: maximumUnitsToPick,
                    buffNameFilter: buffNameFilter,
                    inclusiveBuffFilter: inclusiveBuffFilter
                    );
                var old = p.PassThrough[iterator];
                try
                {
                    foreach (var i in result)
                    {
                        p.PassThrough[iterator] = i;
                        p.Exec(c);
                    }
                }
                catch (BreakLoop) { }
                p.PassThrough[iterator] = old;
                return 0;
            }
        }

        public sealed class BBForNClosestVisibleUnitsInTargetArea : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string iterator, "IteratorVar", @default: "Owner");
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                p.GetBBParam(out Vector3 center, "Center", require: true);
                p.GetBBParam(out float range, "Range", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                p.GetBBParam(out int maximumUnitsToPick, "MaximumUnitsToPick", require: true);
                p.GetBBParam(out string buffNameFilter, "BuffNameFilter", @default: "");
                p.GetBBParam(out bool inclusiveBuffFilter, "InclusiveBuffFilter", @default: true);
                var result = c.BBForNClosestVisibleUnitsInTargetArea(
                    attacker: attacker,
                    center: center,
                    range: range,
                    flags: flags,
                    maximumUnitsToPick: maximumUnitsToPick,
                    buffNameFilter: buffNameFilter,
                    inclusiveBuffFilter: inclusiveBuffFilter
                    );
                var old = p.PassThrough[iterator];
                try
                {
                    foreach (var i in result)
                    {
                        p.PassThrough[iterator] = i;
                        p.Exec(c);
                    }
                }
                catch (BreakLoop) { }
                p.PassThrough[iterator] = old;
                return 0;
            }
        }

        public sealed class BBGetBuffRemainingDuration : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                var buffName = p.GetInBlock("BuffName").AsString().Default();
                var result = c.BBGetBuffRemainingDuration(
                    target: target,
                    buffName: buffName
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }

        public sealed class BBGetBuffStartTime : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out string buffName, "BuffName", require: true);
                var result = c.BBGetBuffStartTime(
                    target: target,
                    buffName: buffName
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }

        public sealed class BBGetCastRange : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit spellSlotOwner, "SpellSlotOwner", require: true);
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                var result = c.BBGetCastRange(
                    spellSlotOwner: spellSlotOwner,
                    slot: slot
                    );
                p.SetBBParam("Range", result);
                return 0;
            }
        }

        public sealed class BBGetCastSpellDragEndPos : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var result = c.BBGetCastSpellDragEndPos();
                p.SetInVarTable("DestVarTable", "DestVar", result);
                return 0;
            }
        }

        public sealed class BBGetCastSpellTargetPos : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var result = c.BBGetCastSpellTargetPos();
                p.SetInVarTable("DestVarTable", "DestVar", result);
                return 0;
            }
        }

        public sealed class BBGetChampionBySkinName : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string skin, "Skin", require: true);
                p.GetBBParam(out TeamID team, "Team", require: true);
                var result = c.BBGetChampionBySkinName(
                    skin: skin,
                    team: team
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }

        public sealed class BBGetConnectedStatus : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                var result = c.BBGetConnectedStatus(
                    unit: unit
                    );
                p.SetBBParam("UnitConnected", result);
                return 0;
            }
        }

        public sealed class BBGetDamagingBuffName : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var result = c.BBGetDamagingBuffName();
                p.SetBBParam("Dest", result);
                return 0;
            }
        }

        public sealed class BBGetFlatPARPoolMod : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                var result = c.BBGetFlatPARPoolMod(
                    target: target,
                    delta: delta,
                    PARType: PARType
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }

        public sealed class BBGetFlatPARRegenMod : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                var result = c.BBGetFlatPARPoolMod(
                    target: target,
                    delta: delta,
                    PARType: PARType
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }

        public sealed class BBGetGameTime : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var result = c.BBGetGameTime();
                p.SetBBParam("Seconds", result);
                return 0;
            }
        }

        public sealed class BBGetGroundHeight : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 queryPos, "QueryPos", require: true);
                var result = c.BBGetGroundHeight(
                    queryPos: queryPos
                    );
                p.SetBBParam("GroundPos", result);
                return 0;
            }
        }

        public sealed class BBGetHeightDifference : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 pos1, "Pos1", require: true);
                p.GetBBParam(out Vector3 pos2, "Pos2", require: true);
                var result = c.BBGetHeightDifference(
                    pos1: pos1,
                    pos2: pos2
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }

        public sealed class BBGetIsZombie : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                var result = c.BBGetIsZombie(
                    unit: unit
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }

        public sealed class BBGetMinionAcquirable : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit");
                var result = c.BBGetMinionAcquirable(
                    unit: unit
                    );
                p.SetBBParam("Value", result);
                return 0;
            }
        }

        public sealed class BBGetMissilePosFromID : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out int targetID, "TargetID", require: true);
                var result = c.BBGetMissilePosFromID(
                    targetID: targetID
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }

        public sealed class BBGetNearestPassablePosition : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 position, "Position", require: true);
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                var result = c.BBGetNearestPassablePosition(
                    position: position,
                    owner: owner
                    );
                p.SetBBParam("NewPosition", result);
                return 0;
            }
        }

        public sealed class BBGetNearSight : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Owner", require: true);
                var result = c.BBGetNearSight(
                    unit: unit
                    );
                p.SetBBParam("NearSight", result);
                return 0;
            }
        }

        public sealed class BBGetNumberOfHeroesOnTeam : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out TeamID team, "Team", require: true);
                p.GetBBParam(out bool connectedFromStart, "ConnectedFromStart", require: true);
                p.GetBBParam(out bool includeBots, "IncludeBots", require: true);
                var result = c.BBGetNumberOfHeroesOnTeam(
                    team: team,
                    connectedFromStart: connectedFromStart,
                    includeBots: includeBots
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }

        public sealed class BBGetOffsetAngle : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                p.GetBBParam(out Vector3 offsetPoint, "OffsetPoint", require: true);
                var result = c.BBGetOffsetAngle(
                    unit: unit,
                    offsetPoint: offsetPoint
                    );
                p.SetBBParam("OutputAngle", result);
                return 0;
            }
        }

        public sealed class BBGetPARCostInc : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit spellSlotOwner, "SpellSlotOwner", require: true);
                p.GetBBParam(out SlotsType slotType, "SlotType", require: true);
                p.GetBBParam(out int spellSlot, "SpellSlot", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                var result = c.BBGetPARCostInc(
                    spellSlotOwner: spellSlotOwner,
                    slotType: slotType,
                    spellSlot: spellSlot,
                    PARType: PARType
                    );
                p.SetBBParam("IncCost", result);
                return 0;
            }
        }

        public sealed class BBGetPARMultiplicativeCostInc : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit spellSlotOwner, "SpellSlotOwner", require: true);
                p.GetBBParam(out SlotsType slotType, "SlotType", require: true);
                p.GetBBParam(out int spellSlot, "SpellSlot", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                var result = c.BBGetPARMultiplicativeCostInc(
                    spellSlotOwner: spellSlotOwner,
                    slotType: slotType,
                    spellSlot: spellSlot,
                    PARType: PARType
                    );
                p.SetBBParam("IncCost", result);
                return 0;
            }
        }

        public sealed class BBGetPercentPARPoolMod : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                var result = c.BBGetFlatPARPoolMod(
                    target: target,
                    delta: delta,
                    PARType: PARType
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }

        public sealed class BBGetPercentPARRegenMod : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                var result = c.BBGetFlatPARPoolMod(
                    target: target,
                    delta: delta,
                    PARType: PARType
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }

        public sealed class BBGetPetOwner : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit pet, "Pet", require: true);
                var result = c.BBGetPetOwner(
                    pet: pet
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }

        public sealed class BBGetPointByUnitFacingOffset : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                p.GetBBParam(out float distance, "Distance", require: true);
                p.GetBBParam(out float offsetAngle, "OffsetAngle", require: true);
                var result = c.BBGetPointByUnitFacingOffset(
                    unit: unit,
                    distance: distance,
                    offsetAngle: offsetAngle
                    );
                p.SetBBParam("Position", result);
                return 0;
            }
        }

        public sealed class BBGetRandomPointInAreaPosition : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 pos, "Pos", require: true);
                p.GetBBParam(out float radius, "Radius", require: true);
                p.GetBBParam(out float innerRadius, "InnerRadius");
                var result = c.BBGetRandomPointInAreaPosition(
                    pos: pos,
                    radius: radius,
                    innerRadius: innerRadius
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }

        public sealed class BBGetRandomPointInAreaUnit : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float radius, "Radius", require: true);
                p.GetBBParam(out float innerRadius, "InnerRadius");
                var result = c.BBGetRandomPointInAreaUnit(
                    target: target,
                    radius: radius,
                    innerRadius: innerRadius
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }

        public sealed class BBGetScaleSkinCoef : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                var result = c.BBGetScaleSkinCoef(
                    target: target
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }

        public sealed class BBGetSkinID : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                var result = c.BBGetSkinID(
                    unit: unit
                    );
                p.SetBBParam("SkinID", result);
                return 0;
            }
        }

        public sealed class BBGetUnitPosition : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                var result = c.BBGetUnitPosition(
                    unit: unit
                    );
                p.SetBBParam("Position", result);
                return 0;
            }
        }

        public sealed class BBIncExp : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                c.BBIncExp(
                    target: target,
                    delta: delta
                    );
                return 0;
            }
        }

        public sealed class BBIncFlatPARPoolMod : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                c.BBIncFlatPARPoolMod(
                    target: target,
                    delta: delta,
                    PARType: PARType
                    );
                return 0;
            }
        }

        public sealed class BBIncFlatPARRegenMod : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                c.BBIncFlatPARRegenMod(
                    target: target,
                    delta: delta,
                    PARType: PARType
                    );
                return 0;
            }
        }

        public sealed class BBIncGold : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                p.GetBBParam(out float delta, "Delta", require: true);
                c.BBIncGold(
                    target: target,
                    delta: delta
                    );
                return 0;
            }
        }

        public sealed class BBIncHealth : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                var healer = p.GetInVar("HealerVar").AsUnit().Default();
                c.BBIncHealth(
                    target: target,
                    delta: delta,
                    healer: healer
                    );
                return 0;
            }
        }

        public sealed class BBIncMaxHealth : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out bool incCurrentHealth, "IncCurrentHealth", require: true);
                c.BBIncMaxHealth(
                    target: target,
                    delta: delta,
                    incCurrentHealth: incCurrentHealth
                    );
                return 0;
            }
        }

        public sealed class BBIncPAR : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                c.BBIncPAR(
                    target: target,
                    delta: delta,
                    PARType: PARType
                    );
                return 0;
            }
        }

        public sealed class BBIncPercentPARPoolMod : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                c.BBIncPercentPARPoolMod(
                    target: target,
                    delta: delta,
                    PARType: PARType
                    );
                return 0;
            }
        }

        public sealed class BBIncPercentPARRegenMod : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                c.BBIncPercentPARRegenMod(
                    target: target,
                    delta: delta,
                    PARType: PARType
                    );
                return 0;
            }
        }

        public sealed class BBIncPermanentExpReward : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                c.BBIncPermanentExpReward(
                    target: target,
                    delta: delta
                    );
                return 0;
            }
        }

        public sealed class BBIncPermanentFlatPARPoolMod : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                c.BBIncPermanentFlatPARPoolMod(
                    target: target,
                    delta: delta,
                    PARType: PARType
                    );
                return 0;
            }
        }

        public sealed class BBIncPermanentFlatPARRegenMod : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                c.BBIncPermanentFlatPARRegenMod(
                    target: target,
                    delta: delta,
                    PARType: PARType
                    );
                return 0;
            }
        }

        public sealed class BBIncPermanentGoldReward : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                c.BBIncPermanentGoldReward(
                    target: target,
                    delta: delta
                    );
                return 0;
            }
        }

        public sealed class BBIncPermanentPercentPARPoolMod : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                c.BBIncPermanentPercentPARPoolMod(
                    target: target,
                    delta: delta,
                    PARType: PARType
                    );
                return 0;
            }
        }

        public sealed class BBIncPermanentPercentPARRegenMod : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float delta, "Delta", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                c.BBIncPermanentPercentPARRegenMod(
                    target: target,
                    delta: delta,
                    PARType: PARType
                    );
                return 0;
            }
        }

        public sealed class BBIncreaseShield : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float amount, "Amount", require: true);
                p.GetBBParam(out bool magicShield, "MagicShield", require: true);
                p.GetBBParam(out bool physicalShield, "PhysicalShield", require: true);
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                c.BBIncreaseShield(
                    amount: amount,
                    magicShield: magicShield,
                    physicalShield: physicalShield,
                    unit: unit
                    );
                return 0;
            }
        }

        public sealed class BBIncScaleSkinCoef : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float scale, "Scale", require: true);
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                c.BBIncScaleSkinCoef(
                    scale: scale,
                    owner: owner
                    );
                return 0;
            }
        }

        public sealed class BBIncSpellLevel : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit spellSlotOwner, "SpellSlotOwner", require: true);
                p.GetBBParam(out SlotsType slotType, "SlotType", require: true);
                p.GetBBParam(out int spellSlot, "SpellSlot", require: true);
                c.BBIncSpellLevel(
                    spellSlotOwner: spellSlotOwner,
                    slotType: slotType,
                    spellSlot: spellSlot
                    );
                return 0;
            }
        }

        public sealed class BBIsInBrush : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                var result = c.BBIsInBrush(
                    unit: unit
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }

        public sealed class BBIsPathable : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 destPos, "DestPos", require: true);
                var result = c.BBIsPathable(
                    destPos: destPos
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }

        public sealed class BBLinkVisibility : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit1, "Unit1", require: true);
                p.GetBBParam(out IUnit unit2, "Unit2", require: true);
                c.BBLinkVisibility(
                    unit1: unit1,
                    unit2: unit2
                    );
                return 0;
            }
        }

        public sealed class BBModifyDebugCircleColor : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out int debugCircleID, "DebugCircleID", require: true);
                p.GetBBParam(out int colorR, "ColorR", require: true);
                p.GetBBParam(out int colorG, "ColorG", require: true);
                p.GetBBParam(out int colorB, "ColorB", require: true);
                p.GetBBParam(out int colorA, "ColorA", require: true);
                c.BBModifyDebugCircleColor(
                    debugCircleID: debugCircleID,
                    colorR: colorR,
                    colorG: colorG,
                    colorB: colorB,
                    colorA: colorA
                    );
                return 0;
            }
        }

        public sealed class BBModifyDebugCircleRadius : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out int debugCircleID, "DebugCircleID", require: true);
                p.GetBBParam(out float radius, "Radius", require: true);
                c.BBModifyDebugCircleRadius(
                    debugCircleID: debugCircleID,
                    radius: radius
                    );
                return 0;
            }
        }

        public sealed class BBModifyShield : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float amount, "Amount", require: true);
                p.GetBBParam(out bool magicShield, "MagicShield", require: true);
                p.GetBBParam(out bool physicalShield, "PhysicalShield", require: true);
                p.GetBBParam(out bool noFade, "NoFade", require: true);
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                c.BBModifyShield(
                    amount: amount,
                    magicShield: magicShield,
                    physicalShield: physicalShield,
                    noFade: noFade,
                    unit: unit
                    );
                return 0;
            }
        }

        public sealed class BBMove : BBFunction
        {
            public override int Call(IContext c, Params p) => throw new NotImplementedException();
        }

        public sealed class BBMoveAway : BBFunction
        {
            public override int Call(IContext c, Params p) => throw new NotImplementedException();
        }

        public sealed class BBMoveToUnit : BBFunction
        {
            public override int Call(IContext c, Params p) => throw new NotImplementedException();
        }

        public sealed class BBOverrideAnimation : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out string toOverrideAnim, "ToOverrideAnim", require: true);
                p.GetBBParam(out string overrideAnim, "OverrideAnim", require: true);
                c.BBOverrideAnimation(
                    owner: owner,
                    toOverrideAnim: toOverrideAnim,
                    overrideAnim: overrideAnim
                    );
                return 0;
            }
        }

        public sealed class BBOverrideAutoAttack : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out SlotsType slotType, "SlotType", require: true);
                p.GetBBParam(out int spellSlot, "SpellSlot", require: true);
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out int autoAttackSpellLevel, "AutoAttackSpellLevel", require: true);
                p.GetBBParam(out bool cancelAttack, "CancelAttack", @default: true);
                c.BBOverrideAutoAttack(
                    slotType: slotType,
                    spellSlot: spellSlot,
                    owner: owner,
                    autoAttackSpellLevel: autoAttackSpellLevel,
                    cancelAttack: cancelAttack
                    );
                return 0;
            }
        }

        public sealed class BBOverrideCastRange : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit spellSlotOwner, "SpellSlotOwner", require: true);
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                p.GetBBParam(out float range, "Range", require: true);
                c.BBOverrideCastRange(
                    spellSlotOwner: spellSlotOwner,
                    slot: slot,
                    range: range
                    );
                return 0;
            }
        }

        public sealed class BBPauseAnimation : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                p.GetBBParam(out bool pause, "Pause", require: true);
                c.BBPauseAnimation(
                    unit: unit,
                    pause: pause
                    );
                return 0;
            }
        }

        public sealed class BBPingUnit : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out bool playSound, "PlaySound", @default: true);
                c.BBPingUnit(
                    owner: owner,
                    target: target,
                    playSound: playSound
                    );
                return 0;
            }
        }

        public sealed class BBPlayAnimation : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out string animationName, "AnimationName", require: true);
                p.GetBBParam(out float scaleTime, "ScaleTime", require: true);
                p.GetBBParam(out bool loop, "Loop");
                p.GetBBParam(out bool blend, "Blend", @default: true);
                p.GetBBParam(out bool @lock, "Lock", @default: true);
                c.BBPlayAnimation(
                    target: target,
                    animationName: animationName,
                    scaleTime: scaleTime,
                    loop: loop,
                    blend: blend,
                    @lock: @lock
                    );
                return 0;
            }
        }

        public sealed class BBPopAllCharacterData : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBPopAllCharacterData(
                    target: target
                    );
                return 0;
            }
        }

        public sealed class BBPopCharacterData : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out int id, "ID", require: true);
                c.BBPopCharacterData(
                    target: target,
                    id: id
                    );
                return 0;
            }
        }

        public sealed class BBPopCharacterFade : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out int id, "ID", require: true);
                c.BBPopCharacterFade(
                    target: target,
                    id: id
                    );
                return 0;
            }
        }

        public sealed class BBPreloadCharacter : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string name, "Name", require: true);
                c.BBPreloadCharacter(
                    name: name
                    );
                return 0;
            }
        }

        public sealed class BBPreloadParticle : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string name, "Name", require: true);
                c.BBPreloadParticle(
                    name: name
                    );
                return 0;
            }
        }

        public sealed class BBPreloadSpell : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string name, "Name", require: true);
                c.BBPreloadSpell(
                    name: name
                    );
                return 0;
            }
        }

        public sealed class BBPushCharacterData : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out string skinName, "SkinName", require: true);
                p.GetBBParam(out bool overrideSpells, "OverrideSpells");
                var result = c.BBPushCharacterData(
                    target: target,
                    skinName: skinName,
                    overrideSpells: overrideSpells
                    );
                p.SetBBParam("ID", result);
                return 0;
            }
        }

        public sealed class BBPushCharacterFade : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float fadeAmount, "FadeAmount", require: true);
                p.GetBBParam(out float fadeTime, "fadeTime", require: true);
                var result = c.BBPushCharacterFade(
                    target: target,
                    fadeAmount: fadeAmount,
                    fadeTime: fadeTime
                    );
                p.SetBBParam("ID", result);
                return 0;
            }
        }

        public sealed class BBRedirectGold : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit redirectSource, "RedirectSource", require: true);
                p.GetBBParam(out IUnit redirectTarget, "RedirectTarget");
                c.BBRedirectGold(
                    redirectSource: redirectSource,
                    redirectTarget: redirectTarget
                    );
                return 0;
            }
        }

        public sealed class BBReduceShield : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float amount, "Amount", require: true);
                p.GetBBParam(out bool magicShield, "MagicShield", require: true);
                p.GetBBParam(out bool physicalShield, "PhysicalShield", require: true);
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                c.BBReduceShield(
                    amount: amount,
                    magicShield: magicShield,
                    physicalShield: physicalShield,
                    unit: unit
                    );
                return 0;
            }
        }

        public sealed class BBRemoveBrushCircle : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out int id, "ID", require: true);
                c.BBRemoveBrushCircle(
                    id: id
                    );
                return 0;
            }
        }

        public sealed class BBRemoveDebugCircle : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out int debugCircleID, "DebugCircleID", require: true);
                c.BBRemoveDebugCircle(
                    debugCircleID: debugCircleID
                    );
                return 0;
            }
        }

        public sealed class BBRemoveLinkVisibility : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit1, "Unit1");
                p.GetBBParam(out IUnit unit2, "Unit2");
                c.BBRemoveLinkVisibility(
                    unit1: unit1,
                    unit2: unit2
                    );
                return 0;
            }
        }

        public sealed class BBRemoveOverrideAutoAttack : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out bool cancelAttack, "CancelAttack", @default: true);
                c.BBRemoveOverrideAutoAttack(
                    owner: owner,
                    cancelAttack: cancelAttack
                    );
                return 0;
            }
        }

        public sealed class BBRemovePerceptionBubble : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string tableVar, "BubbleIDVarTable", require: true);
                p.GetBBParam(out string idVar, "BubbleIDVar", require: true);
                var id = p.GetInVarTable(tableVar, idVar).AsInt().Require();
                var bubleID = id;
                c.BBRemovePerceptionBubble(
                    bubleID: bubleID
                    );
                return 0;
            }
        }

        public sealed class BBRemoveShield : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float amount, "Amount", require: true);
                p.GetBBParam(out bool magicShield, "MagicShield", require: true);
                p.GetBBParam(out bool physicalShield, "PhysicalShield", require: true);
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                c.BBRemoveShield(
                    amount: amount,
                    magicShield: magicShield,
                    physicalShield: physicalShield,
                    unit: unit
                    );
                return 0;
            }
        }

        public sealed class BBResetVoiceOverride : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBResetVoiceOverride(
                    target: target
                    );
                return 0;
            }
        }

        public sealed class BBSealSpellSlot : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out SlotsType slotType, "SlotType", require: true);
                p.GetBBParam(out int spellSlot, "SpellSlot", require: true);
                p.GetBBParam(out bool state, "State", require: true);
                p.GetBBParam(out SpellbookType spellbookType, "SpellbookType");
                c.BBSealSpellSlot(
                    target: target,
                    slotType: slotType,
                    spellSlot: spellSlot,
                    state: state,
                    spellbookType: spellbookType
                    );
                return 0;
            }
        }

        public sealed class BBSetAutoAcquireTargets : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out bool value, "Value", require: true);
                c.BBSetAutoAcquireTargets(
                    target: target,
                    value: value
                    );
                return 0;
            }
        }

        public sealed class BBSetAutoAttackTargetingFlags : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                p.GetBBParam(out SpellFlagsType flags, "Flags", require: true);
                c.BBSetAutoAttackTargetingFlags(
                    unit: unit,
                    flags: flags
                    );
                return 0;
            }
        }

        public sealed class BBSetBuffCasterUnit : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var result = c.BBSetBuffCasterUnit();
                p.SetBBParam("Caster", result);
                return 0;
            }
        }

        public sealed class BBSetBuffToolTipVar : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float value, "Value", require: true);
                p.GetBBParam(out int index, "Index", require: true);
                c.BBSetBuffToolTipVar(
                    value: value,
                    index: index
                    );
                return 0;
            }
        }

        public sealed class BBSetCallForHelpSuppresser : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldSuppressCallForHelp = p.GetInBlock("ShouldSuppressCallForHelp").AsBool().Require();
                c.BBSetCallForHelpSuppresser(
                    target: target,
                    shouldSuppressCallForHelp: shouldSuppressCallForHelp
                    );
                return 0;
            }
        }

        public sealed class BBSetCameraPosition : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out Vector3 position, "Position", require: true);
                c.BBSetCameraPosition(
                    owner: owner,
                    position: position
                    );
                return 0;
            }
        }

        public sealed class BBSetCharacterDebugRadius : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out float radius, "Radius", require: true);
                c.BBSetCharacterDebugRadius(
                    target: target,
                    radius: radius
                    );
                return 0;
            }
        }

        public sealed class BBSetDisarmed : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldDisarm = p.GetInBlock("ShouldDisarm").AsBool().Require();
                c.BBSetDisarmed(
                    target: target,
                    shouldDisarm: shouldDisarm
                    );
                return 0;
            }
        }

        public sealed class BBSetDodgePiercing : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out bool value, "Value", require: true);
                c.BBSetDodgePiercing(
                    target: target,
                    value: value
                    );
                return 0;
            }
        }

        public sealed class BBSetIgnoreCallForHelp : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldIgnoreCallForHelp = p.GetInBlock("ShouldIgnoreCallForHelp").AsBool().Require();
                c.BBSetIgnoreCallForHelp(
                    target: target,
                    shouldIgnoreCallForHelp: shouldIgnoreCallForHelp
                    );
                return 0;
            }
        }

        public sealed class BBSetMinionAcquirable : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                p.GetBBParam(out bool value, "Value", require: true);
                c.BBSetMinionAcquirable(
                    unit: unit,
                    value: value
                    );
                return 0;
            }
        }

        public sealed class BBSetNearSight : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                p.GetBBParam(out bool isNearSight, "IsNearSight", require: true);
                c.BBSetNearSight(
                    unit: unit,
                    isNearSight: isNearSight
                    );
                return 0;
            }
        }

        public sealed class BBSetNetted : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldNet = p.GetInBlock("ShouldNet").AsBool().Require();
                c.BBSetNetted(
                    target: target,
                    shouldNet: shouldNet
                    );
                return 0;
            }
        }

        public sealed class BBSetNotTargetableToTeam : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out bool toAlly, "ToAlly", require: true);
                p.GetBBParam(out bool toEnemy, "ToEnemy", require: true);
                c.BBSetNotTargetableToTeam(
                    target: target,
                    toAlly: toAlly,
                    toEnemy: toEnemy
                    );
                return 0;
            }
        }

        public sealed class BBSetPacified : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldPacified = p.GetInBlock("ShouldPacified").AsBool().Require();
                c.BBSetPacified(
                    target: target,
                    shouldPacified: shouldPacified
                    );
                return 0;
            }
        }

        public sealed class BBSetPARColorOverride : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit spellSlotOwner, "SpellSlotOwner", require: true);
                p.GetBBParam(out int colorR, "ColorR", require: true);
                p.GetBBParam(out int colorG, "ColorG", require: true);
                p.GetBBParam(out int colorB, "ColorB", require: true);
                p.GetBBParam(out int colorA, "ColorA", require: true);
                p.GetBBParam(out int fadeR, "FadeR", require: true);
                p.GetBBParam(out int fadeG, "FadeG", require: true);
                p.GetBBParam(out int fadeB, "FadeB", require: true);
                p.GetBBParam(out int fadeA, "FadeA", require: true);
                c.BBSetPARColorOverride(
                    spellSlotOwner: spellSlotOwner,
                    colorR: colorR,
                    colorG: colorG,
                    colorB: colorB,
                    colorA: colorA,
                    fadeR: fadeR,
                    fadeG: fadeG,
                    fadeB: fadeB,
                    fadeA: fadeA
                    );
                return 0;
            }
        }

        public sealed class BBSetPARCostInc : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit spellSlotOwner, "SpellSlotOwner", require: true);
                p.GetBBParam(out SlotsType slotType, "SlotType", require: true);
                p.GetBBParam(out int spellSlot, "SpellSlot", require: true);
                p.GetBBParam(out float cost, "Cost", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                c.BBSetPARCostInc(
                    spellSlotOwner: spellSlotOwner,
                    slotType: slotType,
                    spellSlot: spellSlot,
                    cost: cost,
                    PARType: PARType
                    );
                return 0;
            }
        }

        public sealed class BBSetPARMultiplicativeCostInc : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit spellSlotOwner, "SpellSlotOwner", require: true);
                p.GetBBParam(out SlotsType slotType, "SlotType", require: true);
                p.GetBBParam(out int spellSlot, "SpellSlot", require: true);
                p.GetBBParam(out float cost, "Cost", require: true);
                p.GetBBParam(out PARType PARType, "PARType");
                c.BBSetPARMultiplicativeCostInc(
                    spellSlotOwner: spellSlotOwner,
                    slotType: slotType,
                    spellSlot: spellSlot,
                    cost: cost,
                    PARType: PARType
                    );
                return 0;
            }
        }

        public sealed class BBSetPetReturnRadius : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit pet, "Pet", require: true);
                p.GetBBParam(out float petReturnRadius, "PetReturnRadius", require: true);
                c.BBSetPetReturnRadius(
                    pet: pet,
                    petReturnRadius: petReturnRadius
                    );
                return 0;
            }
        }

        public sealed class BBSetRooted : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldRoot = p.GetInBlock("ShouldRoot").AsBool().Require();
                c.BBSetRooted(
                    target: target,
                    shouldRoot: shouldRoot
                    );
                return 0;
            }
        }

        public sealed class BBSetSlotSpellCooldownTimeVer2 : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                p.GetBBParam(out bool broadcastEvent, "BroadcastEvent");
                p.GetBBParam(out float src, "Src", require: true);
                c.BBSetSlotSpellCooldownTimeVer2(
                    owner: owner,
                    slot: slot,
                    broadcastEvent: broadcastEvent,
                    src: src
                    );
                return 0;
            }
        }

        public sealed class BBSetSlotSpellIcon : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                p.GetBBParam(out SpellbookType spellbookType, "SpellbookType", require: true);
                p.GetBBParam(out int iconIndex, "IconIndex", require: true);
                c.BBSetSlotSpellIcon(
                    owner: owner,
                    slot: slot,
                    spellbookType: spellbookType,
                    iconIndex: iconIndex
                    );
                return 0;
            }
        }

        public sealed class BBSetSpell : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                p.GetBBParam(out string spellName, "SpellName", require: true);
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBSetSpell(
                    slot: slot,
                    spellName: spellName,
                    target: target
                    );
                return 0;
            }
        }

        public sealed class BBSetSpellOffsetTarget : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                p.GetBBParam(out string spellName, "SpellName", require: true);
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out IUnit offsetTarget, "OffsetTarget", require: true);
                c.BBSetSpellOffsetTarget(
                    slot: slot,
                    spellName: spellName,
                    owner: owner,
                    offsetTarget: offsetTarget
                    );
                return 0;
            }
        }

        public sealed class BBSetSpellToolTipVar : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float value, "Value", require: true);
                p.GetBBParam(out int index, "Index", require: true);
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBSetSpellToolTipVar(
                    value: value,
                    index: index,
                    slot: slot,
                    target: target
                    );
                return 0;
            }
        }

        public sealed class BBSetStateDisableAmbientGold : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out bool value, "Value", require: true);
                c.BBSetStateDisableAmbientGold(
                    target: target,
                    value: value
                    );
                return 0;
            }
        }

        public sealed class BBSetStunned : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldStun = p.GetInBlock("ShouldStun").AsBool().Require();
                c.BBSetStunned(
                    target: target,
                    shouldStun: shouldStun
                    );
                return 0;
            }
        }

        public sealed class BBSetSuppressCallForHelp : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                var shouldSuppressCallForHelp = p.GetInBlock("ShouldSuppressCallForHelp").AsBool().Require();
                c.BBSetSuppressCallForHelp(
                    target: target,
                    shouldSuppressCallForHelp: shouldSuppressCallForHelp
                    );
                return 0;
            }
        }

        public sealed class BBSetTargetingType : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                p.GetBBParam(out TargetType targetType, "TargetType", require: true);
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBSetTargetingType(
                    slot: slot,
                    targetType: targetType,
                    target: target
                    );
                return 0;
            }
        }

        public sealed class BBSetTriggerUnit : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var result = c.BBSetTriggerUnit();
                p.SetBBParam("Trigger", result);
                return 0;
            }
        }

        public sealed class BBSetUseSlotSpellCooldownTime : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out bool broadcastEvent, "BroadcastEvent");
                p.GetBBParam(out float src, "Src", require: true);
                c.BBSetUseSlotSpellCooldownTime(
                    owner: owner,
                    broadcastEvent: broadcastEvent,
                    src: src
                    );
                return 0;
            }
        }

        public sealed class BBSetVoiceOverride : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out string overrideSuffix, "OverrideSuffix", require: true);
                c.BBSetVoiceOverride(
                    target: target,
                    overrideSuffix: overrideSuffix
                    );
                return 0;
            }
        }

        public sealed class BBShowHealthBar : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                p.GetBBParam(out bool show, "Show", require: true);
                c.BBShowHealthBar(
                    unit: unit,
                    show: show
                    );
                return 0;
            }
        }

        public sealed class BBSkipNextAutoAttack : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBSkipNextAutoAttack(
                    target: target
                   );
                return 0;
            }
        }

        public sealed class BBSpawnMinion : BBFunction
        {
            public override int Call(IContext c, Params p) => throw new NotImplementedException();
        }

        public sealed class BBSpawnPet : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out Vector3 posVar, "PosVar", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out int level, "Level", require: true);
                p.GetBBParam(out int healthBonus, "HealthBonus", require: true);
                p.GetBBParam(out int damageBonus, "DamageBonus", require: true);
                p.GetBBParam(out bool copyItems, "CopyItems", @default: true);
                p.GetBBParam(out string name, "Name", require: true);
                p.GetBBParam(out string skin, "Skin", require: true);
                p.GetBBParam(out string buff, "Buff", require: true);
                p.GetBBParam(out string aiScript, "AiScript", @default: "Pet.lua");
                var result = c.BBSpawnPet(
                    owner: owner,
                    posVar: posVar,
                    duration: duration,
                    level: level,
                    healthBonus: healthBonus,
                    damageBonus: damageBonus,
                    copyItems: copyItems,
                    name: name,
                    skin: skin,
                    buff: buff,
                    aiScript: aiScript
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }

        public sealed class BBSpellBuffAdd : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                p.GetBBParam(out int numberOfStacks, "NumberOfStacks", @default: 1);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out BuffAddType buffAddType, "BuffAddType", require: true);
                p.GetBBParam(out int maxStack, "MaxStack", require: true);
                p.GetBBParam(out int tickRate, "TickRate", require: true);
                p.GetBBParam(out bool stacksExclusive, "StacksExclusive", @default: true);
                p.GetBBParam(out bool canMitigateDuration, "CanMitigateDuration");
                p.GetBBParam(out bool isHiddenOnClient, "IsHiddenOnClient");
                var buffName = p.GetInBlock("BuffName").AsString().Require();
                var buffType = p.GetInBlock("BuffType").AsEnum<BuffType>().Require();
                var buffVars = p.GetInVarOrPass("BuffVarsTable", "NextBuffVar").AsTable() ?? new Table();
                c.BBSpellBuffAdd(
                    target: target,
                    attacker: attacker,
                    numberOfStacks: numberOfStacks,
                    duration: duration,
                    buffAddType: buffAddType,
                    maxStack: maxStack,
                    tickRate: tickRate,
                    stacksExclusive: stacksExclusive,
                    canMitigateDuration: canMitigateDuration,
                    isHiddenOnClient: isHiddenOnClient,
                    buffName: buffName,
                    buffType: buffType,
                    buffVars: buffVars
                    );
                return 0;
            }
        }

        public sealed class BBSpellBuffClear : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                var buffName = p.GetInBlock("BuffName").AsString().Default();
                c.BBSpellBuffClear(
                    target: target,
                    buffName: buffName
                    );
                return 0;
            }
        }

        public sealed class BBSpellBuffRemove : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out IUnit attacker, "Attacker", require: true);
                var buffName = p.GetInBlock("BuffName").AsString().Default();
                p.GetBBParam(out float resetDuration, "ResetDuration");
                c.BBSpellBuffRemove(
                    target: target,
                    attacker: attacker,
                    buffName: buffName,
                    resetDuration: resetDuration
                    );
                return 0;
            }
        }

        public sealed class BBSpellBuffRemoveCurrent : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBSpellBuffRemoveCurrent(
                    target: target
                    );
                throw new BreakExecution();
            }
        }

        public sealed class BBSpellBuffRemoveType : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                var type = p.GetInBlock("Type").AsEnum<BuffType>().Require();
                c.BBSpellBuffRemoveType(
                    target: target,
                    type: type
                    );
                return 0;
            }
        }

        public sealed class BBSpellBuffRenew : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out string buffName, "BuffName", require: true);
                p.GetBBParam(out float resetDuration, "ResetDuration", require: true);
                c.BBSpellBuffRenew(
                    target: target,
                    buffName: buffName,
                    resetDuration: resetDuration
                    );
                return 0;
            }
        }

        public sealed class BBSpellCast : BBFunction
        {
            public override int Call(IContext c, Params p) => throw new NotImplementedException();
        }

        public sealed class BBSpellEffectCreate : BBFunction
        {
            public override int Call(IContext c, Params p) => throw new NotImplementedException();
        }

        public sealed class BBSpellEffectRemove : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string idVarTable, "EffectIDVarTable", require: true);
                p.GetBBParam(out string idVar, "EffectIDVar", require: true);
                var effectID = p.GetInVarTable(idVarTable, idVar).AsInt().Require();
                c.BBSpellEffectRemove(
                    effectID: effectID
                    );
                return 0;
            }
        }

        public sealed class BBStartTrackingCollisions : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out bool value, "Value", require: true);
                c.BBStartTrackingCollisions(
                    target: target,
                    value: value
                    );
                return 0;
            }
        }

        public sealed class BBStopChanneling : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit caster, "Caster", require: true);
                p.GetBBParam(out ChannelingStopCondition stopCondition, "StopCondition", require: true);
                p.GetBBParam(out ChannelingStopSource stopSource, "StopSource", require: true);
                c.BBStopChanneling(
                    caster: caster,
                    stopCondition: stopCondition,
                    stopSource: stopSource
                    );
                return 0;
            }
        }

        public sealed class BBStopCurrentOverrideAnimation : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out string animationName, "AnimationName", require: true);
                p.GetBBParam(out bool blend, "Blend", @default: true);
                c.BBStopCurrentOverrideAnimation(
                    target: target,
                    animationName: animationName,
                    blend: blend
                    );
                return 0;
            }
        }

        public sealed class BBStopMove : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBStopMove(
                    target: target
                    );
                return 0;
            }
        }

        public sealed class BBStopMoveBlock : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBStopMoveBlock(
                    target: target
                    );
                return 0;
            }
        }

        public sealed class BBTeleportToKeyLocation : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out SpawnType location, "Location", require: true);
                p.GetBBParam(out TeamID team, "Team", require: true);
                c.BBTeleportToKeyLocation(
                    owner: owner,
                    location: location,
                    team: team
                    );
                return 0;
            }
        }

        public sealed class BBTeleportToPosition : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out string castPositionName, "CastPositionName", require: true);
                c.BBTeleportToPosition(
                    owner: owner,
                    castPositionName: castPositionName
                    );
                return 0;
            }
        }

        public sealed class BBTestUnitAttributeFlag : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out ExtraAttributeFlag attributeFlag, "AttributeFlag", require: true);
                var result = c.BBTestUnitAttributeFlag(
                    target: target,
                    attributeFlag: attributeFlag
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }

        public sealed class BBUnlockAnimation : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out bool blend, "Blend", @default: true);
                c.BBUnlockAnimation(
                    owner: owner,
                    blend: blend
                    );
                return 0;
            }
        }

        public sealed class BBUpdateCanCast : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                c.BBUpdateCanCast(
                    target: target
                    );
                return 0;
            }
        }
    }
}
