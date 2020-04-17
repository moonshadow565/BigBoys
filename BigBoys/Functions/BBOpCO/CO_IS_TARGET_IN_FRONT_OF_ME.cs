using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBOpCO
    {
        public sealed class CO_IS_TARGET_IN_FRONT_OF_ME : BBOpCO
        {  
            public override bool Call(IContext c, object a, object b) => c.CO_IS_TARGET_IN_FRONT_OF_ME(a, b);
        }
    }
}
