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
        public sealed class BBMath : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var op = p.GetInBlock("MathOp") as BBOpMO;
                var result = op.Require().Call(
                    c,
                    p.GetInVarTableOrBlock("Src1VarTable", "Src1Var", "Src1Value").AsFloat().Require(),
                    p.GetInVarTableOrBlock("Src2VarTable", "Src2Var", "Src2Value").AsFloat()
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }
    }
}