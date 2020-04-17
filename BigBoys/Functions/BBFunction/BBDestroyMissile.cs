﻿using System;
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
        public sealed class BBDestroyMissile : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out int missileID, "MissileID", require: true);
                c.BBDestroyMissile(
                    missileID: missileID
                    );
                return 0;
            }
        }
    }
}