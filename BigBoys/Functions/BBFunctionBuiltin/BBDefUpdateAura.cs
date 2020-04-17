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
        public sealed class BBDefUpdateAura : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var center = p.GetInVarTable("CenterTable", "CenterVar").AsVector3().Require();
                var range = p.GetInBlock("Range").AsFloat().Require();
                var unitScan = p.GetInBlock("UnitScan").AsEnum<UnitScanType>().Require();
                var buffName = p.GetInBlock("BuffName").AsString().Require();
                c.DefUpdateAura(
                    center: center,
                    range: range,
                    unitScan: unitScan,
                    buffName: buffName
                    );
                return 0;
            }
        }
    }
}