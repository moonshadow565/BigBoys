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
        public sealed class BBExecutePeriodicallyReset : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.SetInVarTable("TrackTimeVarTable", "TrackTimeVar", null);
                return 0;
            }
        }
    }
}