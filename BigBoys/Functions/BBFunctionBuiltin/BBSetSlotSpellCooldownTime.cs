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
        public sealed class BBSetSlotSpellCooldownTime : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var owner = p.GetInVar("OwnerVar").AsUnit();
                var src = p.GetInVarTableOrBlock("SrcVarTable", "SrcVar", "SrcValue").AsFloat().Require();
                var type = p.GetInBlock("SlotType").AsEnum<SlotsType>().Require();
                var number = p.GetInVarTableOrBlock("SpellSlotVarTable", "SpellSlotVar", "SpellSlotValue").AsInt().Require();
                var book = p.GetInBlock("SpellbookType").AsEnum<SpellbookType>().Require();
                c.SetSlotSpellCooldownTime(
                    owner: owner,
                    src: src,
                    slot: new SpellSlot(type, number, book)
                    );
                return 0;
            }
        }
    }
}