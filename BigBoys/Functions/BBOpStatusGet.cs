using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract class BBOpStatusGet
    {
        private BBOpStatusGet() {}
        
        public abstract bool Call(IContext c, IUnit target);

        public sealed class GetBrushVisibilityFake : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetBrushVisibilityFake(target);
        }

        public sealed class GetCanAttack : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetCanAttack(target);
        }

        public sealed class GetCanCast : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetCanCast(target);
        }

        public sealed class GetCanMove : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetCanMove(target);
        }

        public sealed class GetCharmed : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetCharmed(target);
        }

        public sealed class GetDisableAmbientGold : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetDisableAmbientGold(target);
        }

        public sealed class GetFeared : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetFeared(target);
        }

        public sealed class GetForceRenderParticles : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetForceRenderParticles(target);
        }

        public sealed class GetGhosted : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetGhosted(target);
        }

        public sealed class GetGhostProof : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetGhostProof(target);
        }

        public sealed class GetInvulnerable : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetInvulnerable(target);
        }

        public sealed class GetMagicImmune : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetMagicImmune(target);
        }

        public sealed class GetNearSight : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetNearSight(target);
        }

        public sealed class GetNoRender : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetNoRender(target);
        }

        public sealed class GetPhysicalImmune : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetPhysicalImmune(target);
        }

        public sealed class GetRevealSpecificUnit : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetRevealSpecificUnit(target);
        }

        public sealed class GetSleep : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetSleep(target);
        }

        public sealed class GetStealthed : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetStealthed(target);
        }

        public sealed class GetSuppressed : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetSuppressed(target);
        }

        public sealed class GetTargetable : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetTargetable(target);
        }

        public sealed class GetTaunted : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.GetTaunted(target);
        }

        public sealed class IsAutoCastOn : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.IsAutoCastOn(target);
        }

        public sealed class IsBaseAI : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.IsBaseAI(target);
        }

        public sealed class IsHeroAI : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.IsHeroAI(target);
        }

        public sealed class IsMelee : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.IsMelee(target);
        }

        public sealed class IsMoving : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.IsMoving(target);
        }

        public sealed class IsRanged : BBOpStatusGet
        {
            public override bool Call(IContext c, IUnit target) => c.IsRanged(target);
        }
    }
}
