using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract class BBOpStatusSet
    {
        private BBOpStatusSet() {}

        public abstract void Call(IContext c, IUnit target, bool newState);

        public sealed class SetBrushVisibilityFake : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetBrushVisibilityFake(target, newState);
        }

        public sealed class SetCallForHelpSuppresser : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetCallForHelpSuppresser(target, newState);
        }

        public sealed class SetCanAttack : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetCanAttack(target, newState);
        }

        public sealed class SetCanCast : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetCanCast(target, newState);
        }

        public sealed class SetCanCastWhileDisabled : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetCanCastWhileDisabled(target, newState);
        }

        public sealed class SetCanMove : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetCanMove(target, newState);
        }

        public sealed class SetCharmed : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetCharmed(target, newState);
        }

        public sealed class SetDisableAmbientGold : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetDisableAmbientGold(target, newState);
        }

        public sealed class SetDisarmed : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetDisarmed(target, newState);
        }

        public sealed class SetFeared : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetFeared(target, newState);
        }

        public sealed class SetForceRenderParticles : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetForceRenderParticles(target, newState);
        }

        public sealed class SetGhosted : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetGhosted(target, newState);
        }

        public sealed class SetGhostProof : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetGhostProof(target, newState);
        }

        public sealed class SetIgnoreCallForHelp : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetIgnoreCallForHelp(target, newState);
        }

        public sealed class SetInvulnerable : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetInvulnerable(target, newState);
        }

        public sealed class SetMagicImmune : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetMagicImmune(target, newState);
        }

        public sealed class SetNearSight : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetNearSight(target, newState);
        }

        public sealed class SetNetted : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetNetted(target, newState);
        }

        public sealed class SetNoRender : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetNoRender(target, newState);
        }

        public sealed class SetNotTargetableToTeam : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetNotTargetableToTeam(target, newState);
        }

        public sealed class SetPacified : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetPacified(target, newState);
        }

        public sealed class SetPhysicalImmune : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetPhysicalImmune(target, newState);
        }

        public sealed class SetRevealSpecificUnit : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetRevealSpecificUnit(target, newState);
        }

        public sealed class SetRooted : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetRooted(target, newState);
        }

        public sealed class SetScaleSkinCoef : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetScaleSkinCoef(target, newState);
        }

        public sealed class SetSilenced : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetSilenced(target, newState);
        }

        public sealed class SetSleep : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetSleep(target, newState);
        }

        public sealed class SetSlotSpellCooldownTime : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetSlotSpellCooldownTime(target, newState);
        }

        public sealed class SetStealthed : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetStealthed(target, newState);
        }

        public sealed class SetStunned : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetStunned(target, newState);
        }

        public sealed class SetSuppressCallForHelp : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetSuppressCallForHelp(target, newState);
        }

        public sealed class SetSuppressed : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetSuppressed(target, newState);
        }

        public sealed class SetTargetable : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetTargetable(target, newState);
        }

        public sealed class SetTaunted : BBOpStatusSet
        {
            public override void Call(IContext c, IUnit target, bool newState) => c.SetTaunted(target, newState);
        }
    }
}
