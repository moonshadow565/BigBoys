using System;
using System.Numerics;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Execution;

namespace BigBoys.Helpers
{
    public static class Conversion
    {
        public static string ToStringOrEmpty(this object value)
        {
            return value as string ?? "";
        }

        public static bool? AsBool(this object value)
        {
            return value as bool?;
        }

        public static string AsString(this object value)
        {
            return value as string;
        }

        public static int? AsInt(this object value)
        {
            return value as int? ?? (int?)(value as float? ?? null);
        }

        public static float? AsFloat(this object value)
        {
            return value as float? ?? value as int?;
        }

        public static Table AsTable(this object value)
        {
            return value as Table;
        }

        public static Vector3? AsVector3(this object value)
        {
            if (value is Table table)
            {
                return new Vector3(
                    x: table["x"]?.AsFloat() ?? 0.0f,
                    y: table["y"]?.AsFloat() ?? 0.0f,
                    z: table["z"]?.AsFloat() ?? 0.0f
                    );
            }
            return value as Vector3?;
        }

        public static IUnit AsUnit(this object value)
        {
            return value as IUnit;
        }

        public static SpellFlagsType? AsSpellFlagsType(this object value)
        {
            if (value is SpellFlagsType value2)
            {
                return value2;
            }
            if (value is string value3)
            {
                SpellFlagsType result = 0;
                foreach (var item in value3.Split(','))
                {
                    var item2 = item.Trim();
                    if (string.IsNullOrEmpty(item2))
                    {
                        continue;
                    }
                    result |= (SpellFlagsType)Enum.Parse(typeof(SpellFlagsType), item2, true);
                }
                if ((result & SpellFlagsType.AffectsAllSides) == 0)
                {
                    result |= SpellFlagsType.AffectsAllSides;
                }
                if ((result & (SpellFlagsType.AffectsAllUnitTypes | SpellFlagsType.AffectBuildings)) == 0)
                {
                    result |= SpellFlagsType.AffectBuildings;
                }
                return result;
            }
            return null;
        }

        public static T? AsEnum<T>(this object value) where T: struct, Enum
        {
            return value as T?;
        }

        public static T Require<T>(this T? value) where T: struct
        {
            return value ?? throw new ArgumentNullException();
        }

        public static T Require<T>(this T value) where T: class
        {
            return value ?? throw new ArgumentNullException();
        }

        public static T Default<T>(this T? value, T def = default) where T : struct
        {
            return value ?? def;
        }

        public static T Default<T>(this T value, T def = default) where T : class
        {
            return value ?? def;
        }
    }
}
