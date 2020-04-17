using System;
using BigBoys.Execution;
using BigBoys.Lua;

namespace BigBoys.Context
{
    public partial interface IContext
    {
        bool CO_DAMAGE_SOURCETYPE_IS(object a, object b);
        bool CO_DAMAGE_SOURCETYPE_IS_NOT(object a, object b);
        bool CO_DIFFERENT_TEAM(object a, object b);
        bool CO_EQUAL(object a, object b);
        bool CO_GREATER_THAN(object a, object b);
        bool CO_GREATER_THAN_OR_EQUAL(object a, object b);
        bool CO_IS_DEAD(object a);
        bool CO_IS_MELEE(object a);
        bool CO_IS_NOT_AI(object a);
        bool CO_IS_NOT_DEAD(object a);
        bool CO_IS_NOT_HERO(object a);
        bool CO_IS_NOT_TURRET(object a);
        bool CO_IS_RANGED(object a);
        bool CO_IS_TARGET_BEHIND_ME(object a, object b);
        bool CO_IS_TARGET_IN_FRONT_OF_ME(object a, object b);
        bool CO_IS_TYPE_AI(object a);
        bool CO_IS_TYPE_HERO(object a);
        bool CO_IS_TYPE_TURRET(object a);
        bool CO_LESS_THAN(object a, object b);
        bool CO_LESS_THAN_OR_EQUAL(object a, object b);
        bool CO_NOT_EQUAL(object a, object b);
        bool CO_RANDOM_CHANCE_LESS_THAN(object a, object b);
        bool CO_SAME_TEAM(object a, object b);
        bool CO_IS_CLONE(object a, object b);
        bool CO_IS_NOT_CLONE(object a, object b);
    }
}
