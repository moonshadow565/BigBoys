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
        public sealed class BBRemovePerceptionBubble : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string tableVar, "BubbleIDVarTable", require: true);
                p.GetBBParam(out string idVar, "BubbleIDVar", require: true);
                var id = p.GetInVarTable(tableVar, idVar).AsInt().Require();
                var bubleID = id;
                c.BBRemovePerceptionBubble(
                    bubleID: bubleID
                    );
                return 0;
            }
        }
    }
}