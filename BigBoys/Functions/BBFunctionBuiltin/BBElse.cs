using System;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBFunction
    {
        public sealed class BBElse : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                if (p.LastResult == 0)
                {
                    p.Exec(c);
                    return 1;
                }
                return 0;
            }
        }
    }
}