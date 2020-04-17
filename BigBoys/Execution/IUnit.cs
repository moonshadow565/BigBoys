using System;
using System.Numerics;
using BigBoys.Enums;

namespace BigBoys.Execution
{
    public interface IUnit
    {
        TeamID TeamID { get; }
        GObjID GObjID { get; }
        Vector3 Position { get;  }
    }
}
