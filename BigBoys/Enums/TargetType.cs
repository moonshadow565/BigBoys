using System;
namespace BigBoys.Enums
{
    public enum TargetType
    {
        TTYPE_Self = 0x0,
        TTYPE_Target = 0x1,
        TTYPE_Area = 0x2,
        TTYPE_Cone = 0x3,
        TTYPE_SelfAOE = 0x4,
        TTYPE_TargetOrLocation = 0x5,
        TTYPE_Location = 0x6,
        TTYPE_Direction = 0x7,
        TTYPE_DragDirection = 0x8,
        TTYPE_OffsetAOE = 0x9,
        TTYPE_OffsetLocation = 0xA,
    }
}
