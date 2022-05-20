using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract class BBOpCO
    {
        private BBOpCO() {}
        
        public abstract bool Call(IContext c, object left, object right);

        public sealed class CO_DAMAGE_SOURCETYPE_IS : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_DAMAGE_SOURCETYPE_IS(a, b);
        }

        public sealed class CO_DAMAGE_SOURCETYPE_IS_NOT : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_DAMAGE_SOURCETYPE_IS_NOT(a, b);
        }

        public sealed class CO_DIFFERENT_TEAM : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_DIFFERENT_TEAM(a, b);
        }

        public sealed class CO_EQUAL : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_EQUAL(a, b);
        }

        public sealed class CO_GREATER_THAN : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_GREATER_THAN(a, b);
        }

        public sealed class CO_GREATER_THAN_OR_EQUAL : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_GREATER_THAN_OR_EQUAL(a, b);
        }

        public sealed class CO_IS_CLONE : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_IS_CLONE(a, b);
        }

        public sealed class CO_IS_DEAD : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_IS_DEAD(a);
        }

        public sealed class CO_IS_MELEE : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_IS_MELEE(a);
        }

        public sealed class CO_IS_NOT_AI : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_IS_NOT_AI(a);
        }

        public sealed class CO_IS_NOT_CLONE : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_IS_NOT_CLONE(a, b);
        }

        public sealed class CO_IS_NOT_DEAD : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_IS_NOT_DEAD(a);
        }

        public sealed class CO_IS_NOT_HERO : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_IS_NOT_HERO(a);
        }

        public sealed class CO_IS_NOT_TURRET : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_IS_NOT_TURRET(a);
        }

        public sealed class CO_IS_RANGED : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_IS_RANGED(a);
        }

        public sealed class CO_IS_TARGET_BEHIND_ME : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_IS_TARGET_BEHIND_ME(a, b);
        }

        public sealed class CO_IS_TARGET_IN_FRONT_OF_ME : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_IS_TARGET_IN_FRONT_OF_ME(a, b);
        }

        public sealed class CO_IS_TYPE_AI : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_IS_TYPE_AI(a);
        }

        public sealed class CO_IS_TYPE_HERO : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_IS_TYPE_HERO(a);
        }

        public sealed class CO_IS_TYPE_TURRET : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_IS_TYPE_TURRET(a);
        }

        public sealed class CO_LESS_THAN : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_LESS_THAN(a, b);
        }

        public sealed class CO_LESS_THAN_OR_EQUAL : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_LESS_THAN_OR_EQUAL(a, b);
        }

        public sealed class CO_NOT_EQUAL : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_NOT_EQUAL(a, b);
        }

        public sealed class CO_RANDOM_CHANCE_LESS_THAN : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_RANDOM_CHANCE_LESS_THAN(a, b);
        }

        public sealed class CO_SAME_TEAM : BBOpCO
        {
            public override bool Call(IContext c, object a, object b) => c.CO_SAME_TEAM(a, b);
        }
    }
}
