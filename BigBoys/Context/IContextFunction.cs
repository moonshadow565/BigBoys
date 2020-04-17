using System;
using System.Collections.Generic;
using System.Numerics;
using BigBoys.Enums;
using BigBoys.Execution;
using BigBoys.Lua;

namespace BigBoys.Context
{
    public partial interface IContext
    {
        int BBAddDebugCircle(
            IUnit unit,
            Vector3 center,
            float radius,
            int colorR,
            int colorG,
            int colorB,
            int colorA
            );

        int BBAddPosPerceptionBubble(
            float radius,
            Vector3 pos,
            float duration,
            TeamID team,
            IUnit specificUnitsClientOnly,
            bool revealSteath,
            IUnit revealSpecificUnitOnly
            );

        int BBAddUnitPerceptionBubble(
            float radius,
            float duration,
            IUnit target,
            TeamID team,
            IUnit specificUnitsClientOnly,
            bool revealSteath,
            IUnit revealSpecificUnitOnly
            );

        void BBAdjustCastInfoCenterAOE(
            IUnit owner,
            float radius,
            SpellFlagsType flags
            );

        void BBApplyAssistMarker(
            IUnit target,
            IUnit source,
            float duration
            );

        int BBApplyBrushCircle(
            Vector3 pos,
            float radius
            );

        void BBApplyCallForHelpSuppresser(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplyCharm(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplyDamage(
            IUnit target,
            bool ignoreDamageIncreaseMods,
            bool ignoreDamageCrit,
            HitResult hitResult,
            float damage,
            float percentOfAttack,
            GObjID attacker,
            GObjID callForHelpAttacker,
            DamageTypes damageType,
            DamageSource sourceDamageType,
            float spellDamageRatio,
            float physicalDamageRatio
            );

        void BBApplyDisarm(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplyFear(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplyForceRenderParticles(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplyIgnoreCallForHelp(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplyNearSight(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplyNet(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplyNoRender(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplyPacified(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplyRevealSpecificUnit(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplyRoot(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplySilence(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplySleep(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplyStealth(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplyStun(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplySuppressCallForHelp(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplySuppression(
            IUnit target,
            float duration,
            IUnit attacker
            );

        void BBApplyTaunt(
            IUnit target,
            float duration,
            IUnit attacker
            );

        bool BBCanSeeTarget(
            IUnit viewer,
            IUnit target
            );

        void BBCancelAutoAttack(
            IUnit target,
            bool reset
            );

        void BBClearOverrideAnimation(
            IUnit owner,
            string toOverrideAnim
            );

        void BBClearPARColorOverride(
            IUnit spellSlotOwner
            );

        IUnit BBCloneUnitPet(
            IUnit unitToClone,
            Vector3 pos,
            IUnit goldRedirectTarget,
            IUnit owner,
            float duration,
            bool copyItems,
            bool showMinimapIcon,
            int level,
            int healthBonus,
            int damageBonus,
            string buff,
            string aiScript
            );

        void BBCreateItem(
            IUnit unit,
            int itemID
            );

        void BBDestroyMissile(
            int missileID
            );

        void BBDestroyMissileForTarget(
            IUnit target
            );

        void BBDispellNegativeBuffs(
            IUnit target
            );

        void BBDispellPositiveBuffs(
            IUnit target
            );

        void BBEnableWallOfGrassTracking(
            IUnit unit,
            bool enable
            );

        void BBFaceDirection(
            IUnit target,
            Vector3 location
            );

        void BBFadeInColorFadeEffect(
            float colorRed,
            float colorGreen,
            float colorBlue,
            float fadeTime,
            float maxWeight,
            TeamID specificToTeam
            );

        void BBFadeOutColorFadeEffect(
            float fadeTime,
            TeamID specificToTeam
            );

        IEnumerable<IUnit> BBForEachChampion(
            TeamID team,
            string buffNameFilter,
            bool inclusiveBuffFilter
            );

        IEnumerable<IUnit> BBForEachPetInTarget(
            IUnit target,
            string buffNameFilter,
            bool inclusiveBuffFilter
            );

        IEnumerable<Vector3> BBForEachPointAroundCircle(
            Vector3 center,
            float radius,
            int iterations
            );

        IEnumerable<Vector3> BBForEachPointOnLine(
            Vector3 center,
            Vector3 faceTowardsPos,
            float size,
            float pushForward,
            int iterations
            );

        IEnumerable<IUnit> BBForEachUnitInTargetArea(
            IUnit attacker,
            Vector3 center,
            float range,
            SpellFlagsType flags,
            string buffNameFilter,
            bool inclusiveBuffFilter
            );

        void BBForEachUnitInTargetAreaAddBuff(
            IUnit attacker,
            Vector3 center,
            float range,
            SpellFlagsType flags,
            string buffNameFilter,
            bool inclusiveBuffFilter,
            IUnit buffAttacker,
            float buffNumberOfStacks,
            float buffDuration,
            BuffAddType buffAddType,
            float tickRate,
            bool isHiddenOnClient,
            string buffName,
            int buffMaxStack,
            BuffType buffType,
            Table buffVars
            );

        IEnumerable<IUnit> BBForEachUnitInTargetAreaRandom(
            IUnit attacker,
            Vector3 center,
            float range,
            SpellFlagsType flags,
            int maximumUnitsToPick,
            string buffNameFilter,
            bool inclusiveBuffFilter
            );

        IEnumerable<IUnit> BBForEachUnitInTargetRectangle(
            IUnit attacker,
            Vector3 center,
            float halfWidth,
            float halfLength,
            SpellFlagsType flags,
            string buffNameFilter,
            bool inclusiveBuffFilter
            );

        IEnumerable<IUnit> BBForEachVisibleUnitInTargetArea(
            IUnit attacker,
            Vector3 center,
            float range,
            SpellFlagsType flags,
            string buffNameFilter,
            bool inclusiveBuffFilter
            );

        void BBForEachVisibleUnitInTargetAreaAddBuff(
            IUnit attacker,
            Vector3 center,
            float range,
            SpellFlagsType flags,
            string buffNameFilter,
            bool inclusiveBuffFilter,
            IUnit buffAttacker,
            float buffNumberOfStacks,
            float buffDuration,
            BuffAddType buffAddType,
            float tickRate,
            bool isHiddenOnClient,
            string buffName,
            int buffMaxStack,
            BuffType buffType,
            Table buffVars
            );

        IEnumerable<IUnit> BBForEachVisibleUnitInTargetAreaRandom(
            IUnit attacker,
            Vector3 center,
            float range,
            SpellFlagsType flags,
            int maximumUnitsToPick,
            string buffNameFilter,
            bool inclusiveBuffFilter
            );

        IEnumerable<IUnit> BBForEachVisibleUnitInTargetRectangle(
            IUnit attacker,
            Vector3 center,
            float halfWidth,
            float halfLength,
            SpellFlagsType flags,
            string buffNameFilter,
            bool inclusiveBuffFilter
            );

        IEnumerable<IUnit> BBForNClosestUnitsInTargetArea(
            IUnit attacker,
            Vector3 center,
            float range,
            SpellFlagsType flags,
            int maximumUnitsToPick,
            string buffNameFilter,
            bool inclusiveBuffFilter
            );

        IEnumerable<IUnit> BBForNClosestVisibleUnitsInTargetArea(
            IUnit attacker,
            Vector3 center,
            float range,
            SpellFlagsType flags,
            int maximumUnitsToPick,
            string buffNameFilter,
            bool inclusiveBuffFilter
            );

        void BBForceDead(
            IUnit owner
            );

        void BBForceRefreshPath(
            IUnit unit
            );

        float BBGetBuffRemainingDuration(
            IUnit target,
            string buffName
            );

        float BBGetBuffStartTime(
            IUnit target,
            string buffName
            );

        float BBGetCastRange(
            IUnit spellSlotOwner,
            SpellSlot slot
            );

        Vector3 BBGetCastSpellDragEndPos();

        Vector3 BBGetCastSpellTargetPos();

        IUnit BBGetChampionBySkinName(
            string skin,
            TeamID team
            );

        bool BBGetConnectedStatus(
            IUnit unit
            );

        string BBGetDamagingBuffName();

        float BBGetFlatPARPoolMod(
            IUnit target,
            float delta,
            PARType PARType
            );

        float BBGetFlatPARRegenMod(
            IUnit target,
            float delta,
            PARType PARType
            );

        float BBGetGameTime();

        Vector3 BBGetGroundHeight(
            Vector3 queryPos
            );

        float BBGetHeightDifference(
            Vector3 pos1,
            Vector3 pos2
            );

        bool BBGetIsZombie(
            IUnit unit
            );

        bool BBGetMinionAcquirable(
            IUnit unit
            );

        Vector3 BBGetMissilePosFromID(
            int targetID
            );

        bool BBGetNearSight(
            IUnit unit
            );

        Vector3 BBGetNearestPassablePosition(
            Vector3 position,
            IUnit owner
            );

        int BBGetNumberOfHeroesOnTeam(
            TeamID team,
            bool connectedFromStart,
            bool includeBots
            );

        float BBGetOffsetAngle(
            IUnit unit,
            Vector3 offsetPoint
            );

        float BBGetPARCostInc(
            IUnit spellSlotOwner,
            SlotsType slotType,
            int spellSlot,
            PARType PARType
            );

        // IncCostVar string
        // SpellSlotOwnerVar string
        float BBGetPARMultiplicativeCostInc(
            IUnit spellSlotOwner,
            SlotsType slotType,
            int spellSlot,
            PARType PARType
            );

        float BBGetPercentPARPoolMod(
            IUnit target,
            float delta,
            PARType PARType
            );

        float BBGetPercentPARRegenMod(
            IUnit target,
            float delta,
            PARType PARType
            );

        IUnit BBGetPetOwner(
            IUnit pet
            );

        Vector3 BBGetPointByUnitFacingOffset(
            IUnit unit,
            float distance,
            float offsetAngle
            );

        Vector3 BBGetRandomPointInAreaPosition(
            Vector3 pos,
            float radius,
            float innerRadius
            );

        Vector3 BBGetRandomPointInAreaUnit(
            IUnit target,
            float radius,
            float innerRadius
            );

        float BBGetScaleSkinCoef(
            IUnit target
            );

        int BBGetSkinID(
            IUnit unit
            );

        Vector3 BBGetUnitPosition(
            IUnit unit
            );

        void BBIncExp(
            IUnit target,
            float delta
            );


        void BBIncFlatPARPoolMod(
            IUnit target,
            float delta,
            PARType PARType
            );

        void BBIncFlatPARRegenMod(
            IUnit target,
            float delta,
            PARType PARType
            );

        void BBIncGold(
            IUnit target,
            float delta
            );

        void BBIncHealth(
            IUnit target,
            float delta,
            IUnit healer
            );

        void BBIncMaxHealth(
            IUnit target,
            float delta,
            bool incCurrentHealth
            );

        void BBIncPAR(
            IUnit target,
            float delta,
            PARType PARType
            );

        void BBIncPercentPARPoolMod(
            IUnit target,
            float delta,
            PARType PARType
            );

        void BBIncPercentPARRegenMod(
            IUnit target,
            float delta,
            PARType PARType
            );

        void BBIncPermanentExpReward(
            IUnit target,
            float delta
            );

        void BBIncPermanentFlatPARPoolMod(
            IUnit target,
            float delta,
            PARType PARType
            );

        void BBIncPermanentFlatPARRegenMod(
            IUnit target,
            float delta,
            PARType PARType
            );

        void BBIncPermanentGoldReward(
            IUnit target,
            float delta
            );

        void BBIncPermanentPercentPARPoolMod(
            IUnit target,
            float delta,
            PARType PARType
            );

        void BBIncPermanentPercentPARRegenMod(
            IUnit target,
            float delta,
            PARType PARType
            );

        void BBIncScaleSkinCoef(
            float scale,
            IUnit owner
            );

        void BBIncSpellLevel(
            IUnit spellSlotOwner,
            SlotsType slotType,
            int spellSlot
            );

        void BBIncreaseShield(
            float amount,
            bool magicShield,
            bool physicalShield,
            IUnit unit
            );

        bool BBIsInBrush(
            IUnit unit
            );

        bool BBIsPathable(
            Vector3 destPos
            );

        void BBLinkVisibility(
            IUnit unit1,
            IUnit unit2
            );

        void BBModifyDebugCircleColor(
            int debugCircleID,
            int colorR,
            int colorG,
            int colorB,
            int colorA
            );

        void BBModifyDebugCircleRadius(
            int debugCircleID,
            float radius
            );

        Vector3 BBModifyPosition(
            Vector3 position,
            float x,
            float y,
            float z
            );

        void BBModifyShield(
            float amount,
            bool magicShield,
            bool physicalShield,
            bool noFade,
            IUnit unit
            );

        void BBMove(  // FIXME
            IUnit target,
            IUnit unit,
            float gravity, // opt
            float idealDistance, // opt
            float moveBackBy,
            ForceMovementOrdersFacing movementOrdersFacing, // opt
            ForceMovementOrdersType movementOrdersType, // opt
            ForceMovementType movementType, // opt
            float speed
            );

        void BBMoveAway( // FIXME
            IUnit unit,
            IUnit awayFrom,
            float distance,
            float distanceInner,
            float gravity, // opt
            float idealDistance, // opt
            ForceMovementOrdersFacing movementOrdersFacing, // opt
            ForceMovementOrdersType movementOrdersType, // opt
            ForceMovementType movementType, // opt
            float speed
            );

        void BBMoveToUnit( // FIXME
            IUnit target,
            IUnit unit,
            float gravity,
            float idealDistance,
            float maxTrackDistance,
            float moveBackBy,
            ForceMovementOrdersType movementOrdersType,
            float speed,
            float timeOverride
            );

        void BBOverrideAnimation(
            IUnit owner,
            string toOverrideAnim,
            string overrideAnim
            );

        void BBOverrideAutoAttack(
            SlotsType slotType,
            int spellSlot,
            IUnit owner,
            int autoAttackSpellLevel,
            bool cancelAttack
            );

        void BBOverrideCastRange(
            IUnit spellSlotOwner,
            SpellSlot slot,
            float range
            );

        void BBPauseAnimation(
            IUnit unit,
            bool pause
            );

        void BBPingUnit(
            IUnit owner,
            IUnit target,
            bool playSound
            );

        void BBPlayAnimation(
            IUnit target,
            string animationName,
            float scaleTime,
            bool loop,
            bool blend,
            bool @lock
            );

        void BBPopAllCharacterData(
            IUnit target
            );

        void BBPopCharacterData(
            IUnit target,
            int id
            );

        void BBPopCharacterFade(
            IUnit target,
            int id
            );

        void BBPreloadCharacter(
            string name
            );

        void BBPreloadParticle(
            string name
            );

        void BBPreloadSpell(
            string name
            );

        int BBPushCharacterData(
            IUnit target,
            string skinName,
            bool overrideSpells
            );

        int BBPushCharacterFade(
            IUnit target,
            float fadeAmount,
            float fadeTime
            );

        void BBRedirectGold(
            IUnit redirectSource,
            IUnit redirectTarget
            );

        void BBReduceShield(
            float amount,
            bool magicShield,
            bool physicalShield,
            IUnit unit
            );

        void BBRemoveBrushCircle(
            int id
            );

        void BBRemoveDebugCircle(
            int debugCircleID
            );

        void BBRemoveLinkVisibility(
            IUnit unit1,
            IUnit unit2
            );

        void BBRemoveOverrideAutoAttack(
            IUnit owner,
            bool cancelAttack
            );

        void BBRemovePerceptionBubble(
            int bubleID
            );

        void BBRemoveShield(
            float amount,
            bool magicShield,
            bool physicalShield,
            IUnit unit
            );

        void BBResetVoiceOverride(
            IUnit target
            );

        void BBSealSpellSlot(
            IUnit target,
            SlotsType slotType,
            int spellSlot,
            bool state,
            SpellbookType spellbookType
            );

        void BBSetAutoAcquireTargets(
            IUnit target,
            bool value
            );

        void BBSetAutoAttackTargetingFlags(
            IUnit unit,
            SpellFlagsType flags
            );

        IUnit BBSetBuffCasterUnit();

        void BBSetBuffToolTipVar(
            float value,
            int index
            );

        void BBSetCallForHelpSuppresser(
            IUnit target,
            bool shouldSuppressCallForHelp
            );

        void BBSetCameraPosition(
            IUnit owner,
            Vector3 position
            );

        void BBSetCharacterDebugRadius(
            IUnit target,
            float radius
            );

        void BBSetDisarmed(
            IUnit target,
            bool shouldDisarm
            );

        void BBSetDodgePiercing(
            IUnit target,
            bool value
            );

        void BBSetIgnoreCallForHelp(
            IUnit target,
            bool shouldIgnoreCallForHelp
            );

        void BBSetMinionAcquirable(
            IUnit unit,
            bool value
            );

        void BBSetNearSight(
            IUnit unit,
            bool isNearSight
            );

        void BBSetNetted(
            IUnit target,
            bool shouldNet
            );

        void BBSetNotTargetableToTeam(
            IUnit target,
            bool toAlly,
            bool toEnemy
            );

        void BBSetPARColorOverride(
            IUnit spellSlotOwner,
            int colorG,
            int colorR,
            int colorB,
            int colorA,
            int fadeR,
            int fadeG,
            int fadeB,
            int fadeA
            );

        void BBSetPARCostInc(
            IUnit spellSlotOwner,
            SlotsType slotType,
            int spellSlot,
            float cost,
            PARType PARType
            );

        void BBSetPARMultiplicativeCostInc(
            IUnit spellSlotOwner,
            SlotsType slotType,
            int spellSlot,
            float cost,
            PARType PARType
            );

        void BBSetPacified(
            IUnit target,
            bool shouldPacified
            );

        void BBSetPetReturnRadius(
            IUnit pet,
            float petReturnRadius
            );

        void BBSetRooted(
            IUnit target,
            bool shouldRoot
            );

        void BBSetSlotSpellCooldownTimeVer2(
            IUnit owner,
            SpellSlot slot,
            bool broadcastEvent,
            float src
            );

        void BBSetSlotSpellIcon(
            IUnit owner,
            SpellSlot slot,
            SpellbookType spellbookType,
            int iconIndex
            );

        void BBSetSpell(
            SpellSlot slot,
            string spellName,
            IUnit target
            );

        void BBSetSpellOffsetTarget(
            SpellSlot slot,
            string spellName,
            IUnit owner,
            IUnit offsetTarget
            );

        void BBSetSpellToolTipVar(
            float value,
            int index,
            SpellSlot slot,
            IUnit target
            );

        void BBSetStateDisableAmbientGold(
            IUnit target,
            bool value
            );

        void BBSetStunned(
            IUnit target,
            bool shouldStun
            );

        void BBSetSuppressCallForHelp(
            IUnit target,
            bool shouldSuppressCallForHelp
            );

        void BBSetTargetingType(
            SpellSlot slot,
            TargetType targetType,
            IUnit target
            );

        IUnit BBSetTriggerUnit();

        void BBSetUseSlotSpellCooldownTime(
            IUnit owner,
            bool broadcastEvent,
            float src
            );

        void BBSetVoiceOverride(
            IUnit target,
            string overrideSuffix
            );

        void BBShowHealthBar(
            IUnit unit,
            bool show
            );

        void BBSkipNextAutoAttack(
            IUnit target
            );

        IUnit BBSpawnMinion(   // FIXME
            string aiScript, // opt
            bool ignoreCollision,
            bool invulnerable,
            bool isWard, // opt
            bool magicImmune,
            string name,
            bool placemarker, // opt
            bool rooted,
            bool silenced,
            string skin,
            bool stunned,
            TeamID team,
            float visibilitySize,
            Vector3 pos,
            IUnit goldRedirectTargetVar
            );

        IUnit BBSpawnPet(
            IUnit owner,
            Vector3 posVar,
            float duration,
            int level,
            float healthBonus,
            float damageBonus,
            bool copyItems,
            string name,
            string skin,
            string buff,
            string aiScript
            );

        void BBSpellBuffAdd(
            IUnit target,
            IUnit attacker,
            int numberOfStacks,
            float duration,
            BuffAddType buffAddType,
            int maxStack,
            float tickRate,
            bool stacksExclusive,
            bool canMitigateDuration,
            bool isHiddenOnClient,
            string buffName,
            BuffType buffType,
            Table buffVars
            );

        void BBSpellBuffClear(
            IUnit target,
            string buffName
            );

        void BBSpellBuffRenew(
            IUnit target,
            string buffName,
            float resetDuration
            );

        void BBSpellBuffRemove(
            IUnit attacker,
            IUnit target,
            string buffName,
            float resetDuration
            );

        void BBSpellBuffRemoveCurrent(
            IUnit target
            );

        void BBSpellBuffRemoveType(
            IUnit target,
            BuffType type
            );

        void BBSpellCast(   // FIXME
            IUnit caster,
            Vector3 endPos,
            Vector3 pos,
            IUnit target,
            bool fireWithoutCasting,
            bool forceCastingOrChannelling,
            bool overrideCastPosition,
            bool overrideCoolDownCheck,
            float overrideForceLevel,
            float slotNumber,
            SlotsType slotType,
            bool updateAutoAttackTimer,
            bool useAutoAttackSpell
            );

        void BBSpellEffectCreate( // FIXME
            IUnit bindObject,
            int effectID,
            int effectID2,
            TeamID FOWTeamOverride,
            IUnit orientTowards,
            Vector3 pos,
            TeamID specificTeamOnly,
            IUnit specificUnitOnly,
            IUnit targetObject,
            Vector3 targetPos,
            bool bindFlexToOwnerPAR,
            string boneName,
            string effectName,
            string effectNameForOtherTeam,
            TeamID FOWTeam,
            float FOWVisibilityRadius,
            bool facesTarget,
            float flags,
            bool followsGroundTilt,
            bool persistsThroughReconnect,
            bool sendIfOnScreenOrDiscard,
            string targetBoneName,
            bool useSpecificUnit
            );

        void BBSpellEffectRemove(
            int effectID
            );

        void BBStartTrackingCollisions(
            IUnit target,
            bool value
            );

        void BBStopChanneling(
            IUnit caster,
            ChannelingStopCondition stopCondition,
            ChannelingStopSource stopSource
            );

        void BBStopCurrentOverrideAnimation(
            IUnit target,
            string animationName,
            bool blend
            );

        void BBStopMove(
            IUnit target
            );

        void BBStopMoveBlock(
            IUnit target
            );

        void BBTeleportToKeyLocation(
            IUnit owner,
            SpawnType location,
            TeamID team
            );

        void BBTeleportToPosition(
            IUnit owner,
            string castPositionName
            );

        bool BBTestUnitAttributeFlag(
            IUnit target,
            ExtraAttributeFlag attributeFlag
            );

        float BBTimeChannelTickExecute(
            float timeTick
            );

        void BBUpdateCanCast(
            IUnit target
            );

        void BBUnlockAnimation(
            IUnit owner,
            bool blend
            );
    }
}
