using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBOpMO
    {
        public sealed class MO_SUBTRACT : BBOpMO
        {  
            public override float Call(IContext c, float a, float? b) => c.MO_SUBTRACT(a, b.Require());
        }
    }
}
