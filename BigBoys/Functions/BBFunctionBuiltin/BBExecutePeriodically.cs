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
        public sealed class BBExecutePeriodically : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var tick = p.GetInVarTableOrBlock("TickTimeVarTable", "TickTimeVar", "TimeBetweenExecutions").AsFloat().Require();
                var time = c.GetTime();
                if (p.GetInVarTable("TrackTimeVarTable", "TrackTimeVar").AsFloat() is float track)
                {
                    if (time >= track + tick)
                    {
                        p.SetInVarTable("TrackTimeVarTable", "TrackTimeVar", track + tick);
                        p.Exec(c);
                    }
                }
                else
                {
                    p.SetInVarTable("TrackTimeVarTable", "TrackTimeVar", time);
                    if (p.GetInBlock("ExecuteImmediately").AsBool() is bool b && b)
                    {
                        p.Exec(c);
                    }
                }
                return 0;
            }
        }
    }
}