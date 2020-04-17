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
        public sealed class BBSpellEffectRemove : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out string idVarTable, "EffectIDVarTable", require: true);
                p.GetBBParam(out string idVar, "EffectIDVar", require: true);
                var effectID = p.GetInVarTable(idVarTable, idVar).AsInt().Require();
                c.BBSpellEffectRemove(
                    effectID: effectID
                    );
                return 0;
            }
        }
    }
}