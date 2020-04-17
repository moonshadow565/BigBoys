using System;
namespace BigBoys.Enums
{
    public enum Order
    {
        AI_ORDER_NONE = 0x0,
        AI_HOLD = 0x1,
        AI_MOVETO = 0x2,
        AI_ATTACKTO = 0x3,
        AI_TEMP_CASTSPELL = 0x4,
        AI_PETHARDATTACK = 0x5,
        AI_PETHARDMOVE = 0x6,
        AI_ATTACKMOVE = 0x7,
        AI_TAUNT = 0x8,
        AI_PETHARDRETURN = 0x9,
        AI_STOP = 0xA,
        AI_PETHARDSTOP = 0xB,
    }
}
