using System;
namespace BigBoys.Enums
{
    public enum ForceMovementType
    {
        FURTHEST_WITHIN_RANGE = 0x0,
        FIRST_COLLISION_HIT = 0x1,
        GET_NEAREST_IN_RANGE = 0x2,
        GET_NEAREST_IN_RANGE_INCLUDE_UNITS = 0x3,
        FIRST_WALL_HIT = 0x4,
    }
}
