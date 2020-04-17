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
        public sealed class BBDistanceBetweenObjects : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var object1 = p.GetInVar("ObjectVar1").AsUnit();
                var object2 = p.GetInVar("ObjectVar2").AsUnit();
                var result = c.DistanceBetweenObjects(
                    object1: object1,
                    object2: object2
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }
    }
}