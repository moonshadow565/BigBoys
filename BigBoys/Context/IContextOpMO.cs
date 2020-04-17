using System;
using BigBoys.Execution;
using BigBoys.Lua;

namespace BigBoys.Context
{
    public partial interface IContext
    {
        float MO_ADD(float a, float b);
        float MO_DIVIDE(float a, float b);
        float MO_MAX(float a, float b);
        float MO_MIN(float a, float b);
        float MO_MODULO(float a, float b);
        float MO_MULTIPLY(float a, float b);
        float MO_SUBTRACT(float a, float b);
        float MO_COSINE(float a);
        float MO_ROUND(float a);
        float MO_ROUNDDOWN(float a);
        float MO_ROUNDUP(float a);
        float MO_SIN(float a);
        float MO_TANGENT(float a);
    }
}
