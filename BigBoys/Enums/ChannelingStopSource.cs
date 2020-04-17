using System;
namespace BigBoys.Enums
{
    public enum ChannelingStopSource
    {
        ChannelingStopSource_NotCancelled = 0x0,
        ChannelingStopSource_TimeCompleted = 0x1,
        ChannelingStopSource_Animation = 0x2,
        ChannelingStopSource_LostTarget = 0x3,
        ChannelingStopSource_StunnedOrSilencedOrTaunted = 0x4,
        ChannelingStopSource_ChannelingCondition = 0x5,
        ChannelingStopSource_Die = 0x6,
        ChannelingStopSource_HeroReincarnate = 0x7,
        ChannelingStopSource_Move = 0x8,
        ChannelingStopSource_Attack = 0x9,
        ChannelingStopSource_Casting = 0xA,
        ChannelingStopSource_Unknown = 0xB,
        ChannelingStopSource_NumbOf = 0xC,
    }
}
