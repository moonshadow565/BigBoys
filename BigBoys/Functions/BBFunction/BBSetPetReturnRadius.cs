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
        public sealed class BBSetPetReturnRadius : BBFunction
        {  
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit pet, "Pet", require: true);
                p.GetBBParam(out float petReturnRadius, "PetReturnRadius", require: true);
                c.BBSetPetReturnRadius(
                    pet: pet,
                    petReturnRadius: petReturnRadius
                    );
                return 0;
            }
        }
    }
}