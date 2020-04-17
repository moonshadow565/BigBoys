using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBOpCastInfo
    {
        private BBOpCastInfo() {}
        
        public abstract object Call(IContext c);
    }
}
