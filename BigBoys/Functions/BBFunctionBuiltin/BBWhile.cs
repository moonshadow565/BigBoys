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
        public sealed class BBWhile : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var func = p.GetInBlock("CompareOp") as BBOpCO;
                try
                {
                    for(;;)
                    {
                        var result = func.Require().Call(
                            c,
                            left: p.GetInVarTableOrBlock("Src1VarTable", "Src1Var", "Value1"),
                            right: p.GetInVarTableOrBlock("Src2VarTable", "Src2Var", "Value2")
                            );
                        if (!result)
                        {
                            break;
                        }
                        p.Exec(c);
                    }
                }
                catch (BreakLoop)
                {
                }
                return 0;
            }
        }
    }
}