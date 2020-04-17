using System;
using BigBoys.Execution;
using BigBoys.Lua;

namespace BigBoys.Context
{
    public partial interface IContext
    {
        void SetBrushVisibilityFake(IUnit target, bool newState);
        void SetCallForHelpSuppresser(IUnit target, bool newState);
        void SetCanAttack(IUnit target, bool newState);
        void SetCanCast(IUnit target, bool newState);
        void SetCanCastWhileDisabled(IUnit target, bool newState);
        void SetCanMove(IUnit target, bool newState);
        void SetCharmed(IUnit target, bool newState);
        void SetDisableAmbientGold(IUnit target, bool newState);
        void SetDisarmed(IUnit target, bool newState);
        void SetFeared(IUnit target, bool newState);
        void SetForceRenderParticles(IUnit target, bool newState);
        void SetGhostProof(IUnit target, bool newState);
        void SetGhosted(IUnit target, bool newState);
        void SetIgnoreCallForHelp(IUnit target, bool newState);
        void SetInvulnerable(IUnit target, bool newState);
        void SetMagicImmune(IUnit target, bool newState);
        void SetNearSight(IUnit target, bool newState);
        void SetNetted(IUnit target, bool newState);
        void SetNoRender(IUnit target, bool newState);
        void SetNotTargetableToTeam(IUnit target, bool newState);
        void SetPacified(IUnit target, bool newState);
        void SetPhysicalImmune(IUnit target, bool newState);
        void SetRevealSpecificUnit(IUnit target, bool newState);
        void SetRooted(IUnit target, bool newState);
        void SetScaleSkinCoef(IUnit target, bool newState);
        void SetSilenced(IUnit target, bool newState);
        void SetSleep(IUnit target, bool newState);
        void SetSlotSpellCooldownTime(IUnit target, bool newState);
        void SetStealthed(IUnit target, bool newState);
        void SetStunned(IUnit target, bool newState);
        void SetSuppressCallForHelp(IUnit target, bool newState);
        void SetSuppressed(IUnit target, bool newState);
        void SetTargetable(IUnit target, bool newState);
        void SetTaunted(IUnit target, bool newState);
    }
}
