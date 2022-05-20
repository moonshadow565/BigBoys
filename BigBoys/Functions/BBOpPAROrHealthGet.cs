using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract class BBOpPAROrHealthGet
    {
        private BBOpPAROrHealthGet() {}
        
        public abstract float Call(IContext c, IUnit target, PARType? PARType);

        public sealed class GetHealth : BBOpPAROrHealthGet
        {
            public override float Call(IContext c, IUnit target, PARType? PARType) => c.GetHealth(target);
        }

        public sealed class GetHealthPercent : BBOpPAROrHealthGet
        {
            public override float Call(IContext c, IUnit target, PARType? PARType) => c.GetHealthPercent(target);
        }

        public sealed class GetMaxHealth : BBOpPAROrHealthGet
        {
            public override float Call(IContext c, IUnit target, PARType? PARType) => c.GetMaxHealth(target);
        }

        public sealed class GetMaxPAR : BBOpPAROrHealthGet
        {
            public override float Call(IContext c, IUnit target, PARType? PARType) => c.GetMaxPAR(target, PARType.Require());
        }

        public sealed class GetPAR : BBOpPAROrHealthGet
        {
            public override float Call(IContext c, IUnit target, PARType? PARType) => c.GetPAR(target, PARType.Require());
        }

        public sealed class GetPARCost : BBOpPAROrHealthGet
        {
            public override float Call(IContext c, IUnit target, PARType? PARType) => c.GetPARCost(target, PARType.Require());
        }

        public sealed class GetPARPercent : BBOpPAROrHealthGet
        {
            public override float Call(IContext c, IUnit target, PARType? PARType) => c.GetPARPercent(target, PARType.Require());
        }
    }
}
