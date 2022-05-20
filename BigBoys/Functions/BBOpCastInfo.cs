using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract class BBOpCastInfo
    {
        private BBOpCastInfo() {}
        
        public abstract object Call(IContext c);

        public sealed class GetCasterID : BBOpCastInfo
        {
            public override object Call(IContext c) => c.GetCasterID();
        }

        public sealed class GetCastSpellLevelPlusOne : BBOpCastInfo
        {
            public override object Call(IContext c) => c.GetCastSpellLevelPlusOne();
        }

        public sealed class GetCastSpellLuaInfo : BBOpCastInfo
        {
            public override object Call(IContext c) => c.GetCastSpellLuaInfo();
        }

        public sealed class GetCastSpellTargetPos : BBOpCastInfo
        {
            public override object Call(IContext c) => c.GetCastSpellTargetPos();
        }

        public sealed class GetCastSpellTargetsHitPlusOne : BBOpCastInfo
        {
            public override object Call(IContext c) => c.GetCastSpellTargetsHitPlusOne();
        }

        public sealed class GetIsAttackOverride : BBOpCastInfo
        {
            public override object Call(IContext c) => c.GetIsAttackOverride();
        }

        public sealed class GetSpellName : BBOpCastInfo
        {
            public override object Call(IContext c) => c.GetSpellName();
        }

        public sealed class GetSpellSlot : BBOpCastInfo
        {
            public override object Call(IContext c) => c.GetSpellSlot();
        }
    }
}
