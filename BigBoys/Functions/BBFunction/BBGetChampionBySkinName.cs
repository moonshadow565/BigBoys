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
        public sealed class BBGetChampionBySkinName : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string skin, "Skin", require: true);
                p.GetBBParam(out TeamID team, "Team", require: true);
                var result = c.BBGetChampionBySkinName(
                    skin: skin,
                    team: team
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }
    }
}