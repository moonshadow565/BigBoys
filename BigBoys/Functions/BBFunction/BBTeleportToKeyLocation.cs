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
        public sealed class BBTeleportToKeyLocation : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out SpawnType location, "Location", require: true);
                p.GetBBParam(out TeamID team, "Team", require: true);
                c.BBTeleportToKeyLocation(
                    owner: owner,
                    location: location,
                    team: team
                    );
                return 0;
            }
        }
    }
}