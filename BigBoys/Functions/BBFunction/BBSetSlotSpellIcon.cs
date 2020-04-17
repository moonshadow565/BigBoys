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
        public sealed class BBSetSlotSpellIcon : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner", require: true);
                p.GetBBParam(out SpellSlot slot, "Slot", require: true);
                p.GetBBParam(out SpellbookType spellbookType, "SpellbookType", require: true);
                p.GetBBParam(out int iconIndex, "IconIndex", require: true);
                c.BBSetSlotSpellIcon(
                    owner: owner,
                    slot: slot,
                    spellbookType: spellbookType,
                    iconIndex: iconIndex
                    );
                return 0;
            }
        }
    }
}