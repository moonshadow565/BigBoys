using System;
using System.Reflection;
using System.Collections.Generic;
using BigBoys.Enums;
using BigBoys.Functions;

namespace BigBoys.Lua
{
    public static class Globals
    {
        public static readonly IReadOnlyDictionary<string, object> Lookup = Init();

        private static Dictionary<string, object> Init()
        {
            var result = new Dictionary<string, object>();
            AddFuncs(result, typeof(BBFunction));
            AddFuncs(result, typeof(BBOpCastInfo));
            AddFuncs(result, typeof(BBOpCO));
            AddFuncs(result, typeof(BBOpMO));
            AddFuncs(result, typeof(BBOpPAROrHealthGet));
            AddFuncs(result, typeof(BBOpSlotSpellInfoGet));
            AddFuncs(result, typeof(BBOpStatGet));
            AddFuncs(result, typeof(BBOpStatInc));
            AddFuncs(result, typeof(BBOpStatusGet));
            AddFuncs(result, typeof(BBOpStatusSet));
            AddEnum(result, typeof(BuffAddType));
            AddEnum(result, typeof(BuffType));
            AddEnum(result, typeof(ChannelingStopCondition));
            AddEnum(result, typeof(ChannelingStopSource));
            AddEnum(result, typeof(DamageSource));
            AddEnum(result, typeof(DamageTypes));
            AddEnum(result, typeof(EffectCreate));
            AddEnum(result, typeof(ExtraAttributeFlag));
            AddEnum(result, typeof(ForceMovementOrdersFacing));
            AddEnum(result, typeof(ForceMovementOrdersType));
            AddEnum(result, typeof(ForceMovementType));
            AddEnum(result, typeof(HitResult));
            AddEnum(result, typeof(Order));
            AddEnum(result, typeof(PARType));
            AddEnum(result, typeof(SlotsType));
            AddEnum(result, typeof(SpawnType));
            AddEnum(result, typeof(SpellbookType));
            AddEnum(result, typeof(SpellFlagsType));
            AddEnum(result, typeof(TargetType));
            AddEnum(result, typeof(TeamID));
            AddEnum(result, typeof(TeamIDObj));
            AddEnum(result, typeof(UnitScanType));
            result["true"] = true;
            result["false"] = false;
            result["NoTargetYet"] = null;
            result["NoValidTarget"] = null;
            result["True"] = true; // FIXME: ???
            result["False"] = false; // FIXME: ???
            return result;
        }

        private static void AddFuncs(Dictionary<string, object> result, Type from)
        {
            foreach(var type in from.GetNestedTypes())
            {
                result[type.Name] = type.GetConstructor(new Type[0]).Invoke(new object[0]);
            }
        }

        private static void AddEnum(Dictionary<string, object> result, Type from)
        {
            foreach (var name in from.GetEnumNames())
            {
                result[name] = Enum.Parse(from, name);
            }
        }
    }
}
