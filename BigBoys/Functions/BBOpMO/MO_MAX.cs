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
        public sealed class MO_MAX : BBOpMO
        {  
            public override float Call(IContext c, float a, float? b) => c.MO_MAX(a, b.Require());
        }
    }
}
