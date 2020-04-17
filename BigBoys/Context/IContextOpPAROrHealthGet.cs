using System;
using BigBoys.Enums;
using BigBoys.Execution;
using BigBoys.Lua;

namespace BigBoys.Context
{
    public partial interface IContext
    {
        float GetHealth(IUnit target);
        float GetHealthPercent(IUnit target);
        float GetPAR(IUnit target, PARType PARType);
        float GetPARCost(IUnit target, PARType PARType);
        float GetPARPercent(IUnit target, PARType PARType);
        float GetMaxHealth(IUnit target);
        float GetMaxPAR(IUnit target, PARType PARType);
    }
}
