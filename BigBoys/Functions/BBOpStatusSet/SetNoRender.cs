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
        public sealed class SetNoRender : BBOpStatusSet
        {  
            public override void Call(IContext c, IUnit target, bool newState) => c.SetNoRender(target, newState);
        }
    }
}
