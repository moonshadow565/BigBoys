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
        private BBOpStatusGet() {}
        
        public abstract bool Call(IContext c, IUnit target);
    }
}
