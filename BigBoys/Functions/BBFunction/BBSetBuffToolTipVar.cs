﻿using System;
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
        public sealed class BBSetBuffToolTipVar : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float value, "Value", require: true);
                p.GetBBParam(out int index, "Index", require: true);
                c.BBSetBuffToolTipVar(
                    value: value,
                    index: index
                    );
                return 0;
            }
        }
    }
}