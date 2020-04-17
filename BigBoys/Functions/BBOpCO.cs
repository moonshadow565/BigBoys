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
        private BBOpCO() {}
        
        public abstract bool Call(IContext c, object left, object right);
    }
}
