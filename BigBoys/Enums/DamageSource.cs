﻿using System;
namespace BigBoys.Enums
{
    public enum DamageSource
    {
        DAMAGESOURCE_RAW = 0x0,
        DAMAGESOURCE_INTERNALRAW = 0x1,
        DAMAGESOURCE_PERIODIC = 0x2,
        DAMAGESOURCE_PROC = 0x3,
        DAMAGESOURCE_REACTIVE = 0x4,
        DAMAGESOURCE_ONDEATH = 0x5,
        DAMAGESOURCE_SPELL = 0x6,
        DAMAGESOURCE_ATTACK = 0x7,
        DAMAGESOURCE_DEFAULT = 0x8,
        DAMAGESOURCE_SPELLAOE = 0x9,
        DAMAGESOURCE_SPELLPERSIST = 0xA,
    }
}
