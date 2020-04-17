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
        public sealed class BBTestUnitAttributeFlag : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target", require: true);
                p.GetBBParam(out ExtraAttributeFlag attributeFlag, "AttributeFlag", require: true);
                var result = c.BBTestUnitAttributeFlag(
                    target: target,
                    attributeFlag: attributeFlag
                    );
                p.SetBBParam("Result", result);
                return 0;
            }
        }
    }
}