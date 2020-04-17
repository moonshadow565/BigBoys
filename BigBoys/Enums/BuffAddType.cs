using System;
namespace BigBoys.Enums
{
    public enum BuffAddType
    {
        BUFF_REPLACE_EXISTING = 0x0,
        BUFF_RENEW_EXISTING = 0x1,
        BUFF_STACKS_AND_RENEWS = 0x2,
        BUFF_STACKS_AND_CONTINUE = 0x3,
        BUFF_STACKS_AND_OVERLAPS = 0x4,
    }
}
