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
        public sealed class BBAlert : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var message = p.PerBlock["ToAlert"].ToStringOrEmpty();
                var src = p.GetInVarTable("SrcVarTable", "SrcVar").ToStringOrEmpty();
                c.Alert(
                    message: message,
                    src: src
                    );
                return 0;
            }
        }
    }
}