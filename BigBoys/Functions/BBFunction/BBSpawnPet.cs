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
        public sealed class BBSpawnPet : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out Vector3 posVar, "PosVar", require: true);
                p.GetBBParam(out float duration, "Duration", require: true);
                p.GetBBParam(out int level, "Level", require: true);
                p.GetBBParam(out int healthBonus, "HealthBonus", require: true);
                p.GetBBParam(out int damageBonus, "DamageBonus", require: true);
                p.GetBBParam(out bool copyItems, "CopyItems", @default: true);
                p.GetBBParam(out string name, "Name", require: true);
                p.GetBBParam(out string skin, "Skin", require: true);
                p.GetBBParam(out string buff, "Buff", require: true);
                p.GetBBParam(out string aiScript, "AiScript", @default: "Pet.lua");
                var result = c.BBSpawnPet(
                    owner: owner,
                    posVar: posVar,
                    duration: duration,
                    level: level,
                    healthBonus: healthBonus,
                    damageBonus: damageBonus,
                    copyItems: copyItems,
                    name: name,
                    skin: skin,
                    buff: buff,
                    aiScript: aiScript
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }
    }
}