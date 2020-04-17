using System;
using BigBoys.Execution;
using BigBoys.Lua;

namespace BigBoys.Context
{
    public partial interface IContext
    {
        bool GetBrushVisibilityFake(IUnit target);
        bool GetCanAttack(IUnit target);
        bool GetCanCast(IUnit target);
        bool GetCanMove(IUnit target);
        bool GetCharmed(IUnit target);
        bool GetDisableAmbientGold(IUnit target);
        bool GetFeared(IUnit target);
        bool GetForceRenderParticles(IUnit target);
        bool GetGhostProof(IUnit target);
        bool GetGhosted(IUnit target);
        bool GetInvulnerable(IUnit target);
        bool GetMagicImmune(IUnit target);
        bool GetNearSight(IUnit target);
        bool GetNoRender(IUnit target);
        bool GetPhysicalImmune(IUnit target);
        bool GetRevealSpecificUnit(IUnit target);
        bool GetSleep(IUnit target);
        bool GetStealthed(IUnit target);
        bool GetSuppressed(IUnit target);
        bool GetTargetable(IUnit target);
        bool GetTaunted(IUnit target);
        bool IsAutoCastOn(IUnit target);
        bool IsBaseAI(IUnit target);
        bool IsHeroAI(IUnit target);
        bool IsMelee(IUnit target);
        bool IsMoving(IUnit target);
        bool IsRanged(IUnit target);
    }
}



