using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBOpStatGet
    {
        private BBOpStatGet() {}
        
        public abstract float Call(IContext c, IUnit target);
    }
}
