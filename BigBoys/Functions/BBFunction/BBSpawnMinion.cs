using System;
using System.Numerics;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBFunction
    {
        public sealed class BBSpawnMinion : BBFunction
        {  
            public override int Call(IContext c, Params p) => throw new NotImplementedException();
        }
    }
}