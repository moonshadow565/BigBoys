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
        public sealed class BBGetPetOwner : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit pet, "Pet", require: true);
                var result = c.BBGetPetOwner(
                    pet: pet
                    );
                p.SetBBParam("Dest", result);
                return 0;
            }
        }
    }
}