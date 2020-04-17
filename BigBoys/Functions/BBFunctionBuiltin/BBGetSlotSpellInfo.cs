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
        public sealed class BBGetSlotSpellInfo : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var func = p.GetInBlock("Function") as BBOpSlotSpellInfoGet;
                var result = func.Require().Call(
                    c,
                    p.GetInVar("OwnerVar").AsUnit(),
                    new SpellSlot
                    {
                        Number = p.GetInVarTableOrBlock("SpellSlotVarTable", "SpellSlotVar", "SpellSlotValue").AsInt().Require(),
                        Book = p.GetInBlock("SpellbookType").AsEnum<SpellbookType>().Require(),
                        Type = p.GetInBlock("SlotType").AsEnum<SlotsType>().Require()
                    }
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }
    }
}