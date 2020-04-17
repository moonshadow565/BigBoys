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
        public sealed class BBSetStatus : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var status = p.GetInBlock("Status") as BBOpStatusSet;
                status.Require().Call(
                    c,
                    p.GetInVar("TargetVar").AsUnit(),
                    p.GetInVarTableOrBlock("SrcTable", "SrcVar", "SrcValue").AsBool().Require()
                    );
                return 0;
            }
        }
    }
}