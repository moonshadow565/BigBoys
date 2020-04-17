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
        public sealed class BBCreateItem : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                p.GetBBParam(out int itemID, "ItemID", require: true);
                c.BBCreateItem(
                    unit: unit,
                    itemID: itemID
                    );
                return 0;
            }
        }
    }
}