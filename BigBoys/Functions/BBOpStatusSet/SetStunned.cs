using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBOpStatusSet
    {
        public sealed class SetStunned : BBOpStatusSet
        {  
            public override void Call(IContext c, IUnit target, bool newState) => c.SetStunned(target, newState);
        }
    }
}
