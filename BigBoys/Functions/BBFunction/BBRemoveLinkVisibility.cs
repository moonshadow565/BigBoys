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
        public sealed class BBRemoveLinkVisibility : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit unit1, "Unit1");
                p.GetBBParam(out IUnit unit2, "Unit2");
                c.BBRemoveLinkVisibility(
                    unit1: unit1,
                    unit2: unit2
                    );
                return 0;
            }
        }
    }
}