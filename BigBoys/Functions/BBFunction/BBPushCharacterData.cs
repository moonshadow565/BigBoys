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
        public sealed class BBPushCharacterData : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out string skinName, "SkinName", require: true);
                p.GetBBParam(out bool overrideSpells, "OverrideSpells");
                var result = c.BBPushCharacterData(
                    target: target,
                    skinName: skinName,
                    overrideSpells: overrideSpells
                    );
                p.SetBBParam("ID", result);
                return 0;
            }
        }
    }
}