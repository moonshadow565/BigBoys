using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBOpStatusGet
    {
        public sealed class GetSleep : BBOpStatusGet
        {  
            public override bool Call(IContext c, IUnit target) => c.GetSleep(target);
        }
    }
}
