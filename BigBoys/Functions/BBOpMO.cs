using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract class BBOpMO
    {
        private BBOpMO() {}

        public abstract float Call(IContext c, float a, float? b);

        public sealed class MO_ADD : BBOpMO
        {
            public override float Call(IContext c, float a, float? b) => c.MO_ADD(a, b.Require());
        }

        public sealed class MO_COSINE : BBOpMO
        {
            public override float Call(IContext c, float a, float? b) => c.MO_COSINE(a);
        }

        public sealed class MO_DIVIDE : BBOpMO
        {
            public override float Call(IContext c, float a, float? b) => c.MO_DIVIDE(a, b.Require());
        }

        public sealed class MO_MAX : BBOpMO
        {
            public override float Call(IContext c, float a, float? b) => c.MO_MAX(a, b.Require());
        }

        public sealed class MO_MIN : BBOpMO
        {
            public override float Call(IContext c, float a, float? b) => c.MO_MIN(a, b.Require());
        }

        public sealed class MO_MODULO : BBOpMO
        {
            public override float Call(IContext c, float a, float? b) => c.MO_MODULO(a, b.Require());
        }

        public sealed class MO_MULTIPLY : BBOpMO
        {
            public override float Call(IContext c, float a, float? b) => c.MO_MULTIPLY(a, b.Require());
        }

        public sealed class MO_ROUND : BBOpMO
        {
            public override float Call(IContext c, float a, float? b) => c.MO_ROUND(a);
        }

        public sealed class MO_ROUNDDOWN : BBOpMO
        {
            public override float Call(IContext c, float a, float? b) => c.MO_ROUNDDOWN(a);
        }

        public sealed class MO_ROUNDUP : BBOpMO
        {
            public override float Call(IContext c, float a, float? b) => c.MO_ROUNDUP(a);
        }

        public sealed class MO_SIN : BBOpMO
        {
            public override float Call(IContext c, float a, float? b) => c.MO_SIN(a);
        }

        public sealed class MO_SUBTRACT : BBOpMO
        {
            public override float Call(IContext c, float a, float? b) => c.MO_SUBTRACT(a, b.Require());
        }

        public sealed class MO_TANGENT : BBOpMO
        {
            public override float Call(IContext c, float a, float? b) => c.MO_TANGENT(a);
        }
    }
}
