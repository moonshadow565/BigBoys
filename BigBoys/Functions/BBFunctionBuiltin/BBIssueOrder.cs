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
        public sealed class BBIssueOrder : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                var whom = p.GetInVar("WhomToOrderVar").AsUnit();
                var target = p.GetInVar("TargetOfOrderVar").AsUnit();
                var order = p.GetInBlock("Order").AsEnum<Order>().Require();
                c.IssueOrder(
                    whom: whom,
                    target: target,
                    order: order
                    );
                return 0;
            }
        }
    }
}