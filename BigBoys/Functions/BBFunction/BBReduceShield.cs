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
        public sealed class BBReduceShield : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float amount, "Amount", require: true);
                p.GetBBParam(out bool magicShield, "MagicShield", require: true);
                p.GetBBParam(out bool physicalShield, "PhysicalShield", require: true);
                p.GetBBParam(out IUnit unit, "Unit", require: true);
                c.BBReduceShield(
                    amount: amount,
                    magicShield: magicShield,
                    physicalShield: physicalShield,
                    unit: unit
                    );
                return 0;
            }
        }
    }
}