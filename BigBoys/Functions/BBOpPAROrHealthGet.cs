using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBOpPAROrHealthGet
    {
        private BBOpPAROrHealthGet() {}
        
        public abstract float Call(IContext c, IUnit target, PARType? PARType);
    }
}
