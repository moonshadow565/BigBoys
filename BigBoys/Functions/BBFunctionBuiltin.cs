using System;
using System.Numerics;
using BigBoys.Context;
using BigBoys.Execution;
using BigBoys.Lua;
using BigBoys.Enums;
using BigBoys.Helpers;

namespace BigBoys.Functions
{
    public abstract partial class BBFunction
    {
        public sealed class BBAlert : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var message = p.PerBlock["ToAlert"].ToStringOrEmpty();
                var src = p.GetInVarTable("SrcVarTable", "SrcVar").ToStringOrEmpty();
                c.Alert(
                    message: message,
                    src: src
                    );
                return 0;
            }
        }

        public sealed class BBBreak : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                throw new BreakLoop();
            }
        }

        public sealed class BBBreakExecution : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                throw new BreakExecution();
            }
        }

        public sealed class BBBreakSpellShields : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit();
                var buffVars = p.GetInPass("NextBuffVars").AsTable();
                c.BreakSpellShields(
                    target: target,
                    buffVars: buffVars
                    );
                return 0;
            }
        }

        public sealed class BBDebugSay : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var toSay = p.GetInBlock("ToSay").ToStringOrEmpty();
                var src = p.GetInVarTable("SrcVarTable", "SrcVar").ToStringOrEmpty();
                p.GetBBParam(out IUnit owner, "Owner");
                c.Say(
                    toSay: toSay,
                    src: src,
                    owner: owner
                    );
                return 0;
            }
        }

        public sealed class BBDefUpdateAura : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var center = p.GetInVarTable("CenterTable", "CenterVar").AsVector3().Require();
                var range = p.GetInBlock("Range").AsFloat().Require();
                var unitScan = p.GetInBlock("UnitScan").AsEnum<UnitScanType>().Require();
                var buffName = p.GetInBlock("BuffName").AsString().Require();
                c.DefUpdateAura(
                    center: center,
                    range: range,
                    unitScan: unitScan,
                    buffName: buffName
                    );
                return 0;
            }
        }

        public sealed class BBDistanceBetweenObjectAndPoint : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var @object = p.GetInVar("ObjectVar").AsUnit();
                var point = p.GetInVarTable("PointVarTable", "PointVar", true).AsVector3() ?? default;
                var result = c.DistanceBetweenObjectAndPoint(
                    @object: @object,
                    point: point
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }

        public sealed class BBDistanceBetweenObjects : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var object1 = p.GetInVar("ObjectVar1").AsUnit();
                var object2 = p.GetInVar("ObjectVar2").AsUnit();
                var result = c.DistanceBetweenObjects(
                    object1: object1,
                    object2: object2
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }

        public sealed class BBDistanceBetweenPoints : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var point1 = p.GetInVarTable("PointVar1Table", "Point1Var", true).AsVector3() ?? default;
                var point2 = p.GetInVarTable("PointVar2Table", "Point2Var", true).AsVector3() ?? default;
                var result = c.DistanceBetweenPoints(
                    point1: point1,
                    point2: point2
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }

        public sealed class BBElse : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                if (p.LastResult == 0)
                {
                    p.Exec(c);
                    return 1;
                }
                return 0;
            }
        }

        public sealed class BBElseIf : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                if (p.LastResult != 0)
                {
                    return p.LastResult;
                }
                var func = p.GetInBlock("CompareOp") as BBOpCO;
                var result = func.Require().Call(
                    c,
                    left: p.GetInVarTableOrBlock("Src1VarTable", "Src1Var", "Value1"),
                    right: p.GetInVarTableOrBlock("Src2VarTable", "Src2Var", "Value2")
                    );
                if (result)
                {
                    p.Exec(c);
                    return 1;
                }
                return 0;
            }
        }

        public sealed class BBExecutePeriodically : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var tick = p.GetInVarTableOrBlock("TickTimeVarTable", "TickTimeVar", "TimeBetweenExecutions").AsFloat().Require();
                var time = c.GetTime();
                if (p.GetInVarTable("TrackTimeVarTable", "TrackTimeVar").AsFloat() is float track)
                {
                    if (time >= track + tick)
                    {
                        p.SetInVarTable("TrackTimeVarTable", "TrackTimeVar", track + tick);
                        p.Exec(c);
                    }
                }
                else
                {
                    p.SetInVarTable("TrackTimeVarTable", "TrackTimeVar", time);
                    if (p.GetInBlock("ExecuteImmediately").AsBool() is bool b && b)
                    {
                        p.Exec(c);
                    }
                }
                return 0;
            }
        }

        public sealed class BBExecutePeriodicallyReset : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.SetInVarTable("TrackTimeVarTable", "TrackTimeVar", null);
                return 0;
            }
        }

        public sealed class BBGetArmor : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit();
                var result = c.GetArmor(
                    target: target
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result);
                return 0;
            }
        }

        public sealed class BBGetBuffCountFromAll : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit();
                var buffName = p.GetInBlock("BuffName").AsString().Require();
                var result = c.SpellBuffCount(
                    target: target,
                    buffName: buffName,
                    caster: null
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }

        public sealed class BBGetBuffCountFromCaster : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit();
                var caster = p.GetInVar("CasterVar").AsUnit();
                var buffName = p.GetInBlock("BuffName").AsString().Require();
                var result = c.SpellBuffCount(
                    target: target,
                    caster: caster,
                    buffName: buffName
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }

        public sealed class BBGetCastInfo : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var info = p.GetInBlock("Info") as BBOpCastInfo;
                var result = info.Require().Call(c);
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }

        public sealed class BBGetGold : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit().Require();
                p.GetBBParam(out float delta, "Delta", require: true);
                var result = c.BBLuaGetGold(
                    target: target,
                    delta: delta
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }

        public sealed class BBGetLevel : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit();
                var result = c.GetLevel(
                    target: target
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result);
                return 0;
            }
        }

        public sealed class BBGetPAROrHealth : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var func = p.GetInBlock("Function") as BBOpPAROrHealthGet;
                var result = func.Require().Call(
                    c,
                    p.GetInVar("OwnerVar").AsUnit(),
                    p.GetInBlock("PARType").AsEnum<PARType>()
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }

        public sealed class BBGetSlotSpellInfo : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var func = p.GetInBlock("Function") as BBOpSlotSpellInfoGet;
                var result = func.Require().Call(
                    c,
                    p.GetInVar("OwnerVar").AsUnit(),
                    new SpellSlot
                    {
                        Number = p.GetInVarTableOrBlock("SpellSlotVarTable", "SpellSlotVar", "SpellSlotValue").AsInt().Require(),
                        Book = p.GetInBlock("SpellbookType").AsEnum<SpellbookType>().Require(),
                        Type = p.GetInBlock("SlotType").AsEnum<SlotsType>().Require()
                    }
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }

        public sealed class BBGetSpellBlock : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit();
                var result = c.GetSpellBlock(
                    target: target
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result);
                return 0;
            }
        }

        public sealed class BBGetStat : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var stat = p.GetInBlock("Stat") as BBOpStatGet;
                var result = stat.Require().Call(
                    c,
                    p.GetInVar("TargetVar").AsUnit()
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result);
                return 0;
            }
        }

        public sealed class BBGetStatus : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var status = p.GetInBlock("Status") as BBOpStatusGet;
                var result = status.Require().Call(
                    c,
                    p.GetInVar("TargetVar").AsUnit()
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }

        public sealed class BBGetTeamID : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit();
                var result = c.GetTeamID(
                    target: target
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result);
                return 0;
            }
        }

        public sealed class BBGetTime : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var result = c.GetTime();
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }

        public sealed class BBGetTotalAttackDamage : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit();
                var result = c.GetTotalAttackDamage(
                    target: target
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result);
                return 0;
            }
        }

        public sealed class BBGetUnitSkinName : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit();
                var result = c.GetUnitSkinName(
                    target: target
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result);
                return 0;
            }
        }

        public sealed class BBIf : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var func = p.GetInBlock("CompareOp") as BBOpCO;
                var result = func.Require().Call(
                    c,
                    left: p.GetInVarTableOrBlock("Src1VarTable", "Src1Var", "Value1"),
                    right: p.GetInVarTableOrBlock("Src2VarTable", "Src2Var", "Value2")
                    );
                if (result)
                {
                    p.Exec(c);
                    return 1;
                }
                return 0;
            }
        }

        public sealed class BBIfHasBuff : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner");
                var buffName = p.GetInBlock("BuffName").AsString().Require();
                p.GetBBParam(out IUnit attacker, "Attacker");
                var result = c.HasBuff(
                    owner: owner,
                    buffName: buffName,
                    attacker: attacker
                    );
                if (result)
                {
                    p.Exec(c);
                    return 1;
                }
                return 0;
            }
        }

        public sealed class BBIfHasBuffOfType : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit target, "Target");
                var buffType = p.GetInBlock("BuffType").AsEnum<BuffType>().Require();
                var result = c.HasBuffOfType(
                    target: target,
                    buffType: buffType
                    );
                if (result)
                {
                    p.Exec(c);
                    return 1;
                }
                return 0;
            }
        }

        public sealed class BBIfNotHasBuff : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner");
                var buffName = p.GetInBlock("BuffName").AsString().Require();
                p.GetBBParam(out IUnit attacker, "Caster");
                var result = c.HasBuff(
                    owner: owner,
                    buffName: buffName,
                    attacker: attacker
                    );
                if (!result)
                {
                    p.Exec(c);
                    return 1;
                }
                return 0;
            }
        }

        public sealed class BBIfPARTypeEquals : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner");
                var parType = p.GetInBlock("PARType").AsEnum<PARType>().Require();
                var result = c.HasPARType(
                    owner: owner,
                    parType: parType
                    );
                if (result)
                {
                    p.Exec(c);
                    return 1;
                }
                return 0;
            }
        }

        public sealed class BBIfPARTypeNotEquals : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out IUnit owner, "Owner");
                var parType = p.GetInBlock("PARType").AsEnum<PARType>().Require();
                var result = c.HasPARType(
                    owner: owner,
                    parType: parType
                    );
                if (!result)
                {
                    p.Exec(c);
                    return 1;
                }
                return 0;
            }
        }

        public sealed class BBIncPermanentStat : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var delta = 0.0f;
                delta += p.GetInBlock("Delta").AsFloat() ?? 0.0f;
                delta += p.GetInByLevel("DeltaByLevel").AsFloat() ?? 0.0f;
                delta += p.GetInBlock("Delta").AsFloat() ?? 0.0f;
                var stat = p.GetInBlock("Stat") as BBOpStatInc;
                stat.Require().Call(
                    c,
                    delta,
                    p.GetInVar("TargetVar").AsUnit()
                    );
                return 0;
            }
        }

        public sealed class BBIncStat : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var delta = 0.0f;
                delta += p.GetInBlock("Delta").AsFloat() ?? 0.0f;
                delta += p.GetInByLevel("DeltaByLevel").AsFloat() ?? 0.0f;
                delta += p.GetInBlock("Delta").AsFloat() ?? 0.0f;
                var stat = p.GetInBlock("Stat") as BBOpStatInc;
                stat.Require().Call(
                    c,
                    delta,
                    p.GetInVar("TargetVar").AsUnit()
                    );
                return 0;
            }
        }

        public sealed class BBInvalidateUnit : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.PassThrough[p.GetInBlock("TargetVar").AsString().Require()] = null;
                return 0;
            }
        }

        public sealed class BBIssueOrder : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var whom = p.GetInVar("WhomToOrderVar").AsUnit();
                var target = p.GetInVar("TargetOfOrderVar").AsUnit();
                var order = p.GetInBlock("Order").AsEnum<Order>().Require();
                c.IssueOrder(
                    whom: whom,
                    target: target,
                    order: order
                    );
                return 0;
            }
        }

        public sealed class BBMath : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var op = p.GetInBlock("MathOp") as BBOpMO;
                var result = op.Require().Call(
                    c,
                    p.GetInVarTableOrBlock("Src1VarTable", "Src1Var", "Src1Value").AsFloat().Require(),
                    p.GetInVarTableOrBlock("Src2VarTable", "Src2Var", "Src2Value").AsFloat()
                    );
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }

        public sealed class BBModifyPosition : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out Vector3 position, "Position", require: true);
                p.GetBBParam(out float x, "x", require: true);
                p.GetBBParam(out float y, "x", require: true);
                p.GetBBParam(out float z, "x", require: true);
                position.X += x;
                position.Y += y;
                position.Z += z;
                p.SetBBParam("Position", position);
                return 0;
            }
        }

        public sealed class BBReincarnateHero : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVarTable("TargetVarTable", "TargetVar").AsUnit();
                c.ReincarnateNonDeadHero(
                    target: target
                    );
                return 0;
            }
        }

        public sealed class BBRequireVar : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetInVarTable("RequiredVar", "RequiredVarTable").Require();
                return 0;
            }
        }

        public sealed class BBSay : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var toSay = p.GetInBlock("ToSay").ToStringOrEmpty();
                var src = p.GetInVarTable("SrcVarTable", "SrcVar").ToStringOrEmpty();
                p.GetBBParam(out IUnit owner, "Owner");
                c.Say(
                    toSay: toSay,
                    src: src,
                    owner: owner
                    );
                return 0;
            }
        }

        public sealed class BBSetCanCastWhileDisabled : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var canCast = p.GetInBlock("CanCast").AsBool().Require();
                c.SetCanCastWhileDisabled(
                    canCast: canCast
                    );
                return 0;
            }
        }

        public sealed class BBSetReturnValue : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var result = p.GetInByLevel("SrcValueByLevel") ?? p.GetInVarTableOrBlock("SrcVarTable", "SrcVar", "SrcValue");
                p.PassThrough["ReturnValue"] = result;
                return 0;
            }
        }

        public sealed class BBSetScaleSkinCoef : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var scale = p.GetInVarTableOrBlock("ScaleVarTable", "ScaleVar", "Scale").AsFloat().Require();
                p.GetBBParam(out IUnit owner, "Owner");
                c.SetScaleSkinCoef(
                    scale: scale,
                    owner: owner
                    );
                return 0;
            }
        }

        public sealed class BBSetSlotSpellCooldownTime : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var owner = p.GetInVar("OwnerVar").AsUnit();
                var src = p.GetInVarTableOrBlock("SrcVarTable", "SrcVar", "SrcValue").AsFloat().Require();
                var type = p.GetInBlock("SlotType").AsEnum<SlotsType>().Require();
                var number = p.GetInVarTableOrBlock("SpellSlotVarTable", "SpellSlotVar", "SpellSlotValue").AsInt().Require();
                var book = p.GetInBlock("SpellbookType").AsEnum<SpellbookType>().Require();
                c.SetSlotSpellCooldownTime(
                    owner: owner,
                    src: src,
                    slot: new SpellSlot(type, number, book)
                    );
                return 0;
            }
        }

        public sealed class BBSetSpellCastRange : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                c.SetSpellCastRange(p.GetInBlock("NewRange").AsFloat().Require());
                return 0;
            }
        }

        public sealed class BBSetStatus : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var status = p.GetInBlock("Status") as BBOpStatusSet;
                status.Require().Call(
                    c,
                    p.GetInVar("TargetVar").AsUnit(),
                    p.GetInVarTableOrBlock("SrcTable", "SrcVar", "SrcValue").AsBool().Require()
                    );
                return 0;
            }
        }

        public sealed class BBSetUnit : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var result = p.GetInVar("SrcVar").AsUnit();
                p.PassThrough[p.GetInBlock("DestVar").ToString().Require()] = result;
                return 0;
            }
        }

        public sealed class BBSetVarInTable : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var result = p.GetInByLevel("SrcValueByLevel") ?? p.GetInVarTableOrBlock("SrcVarTable", "SrcVar", "SrcValue");
                p.SetInVarTable("DestVarTable", "DestVar", result, true);
                return 0;
            }
        }

        public sealed class BBSpellBuffRemoveStacks : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var target = p.GetInVar("TargetVar").AsUnit();
                var buffName = p.GetInBlock("BuffName").AsString();
                var attacker = p.GetInVar("AttackerVar").AsUnit();
                var numStacks = p.GetInBlock("NumStacks").AsInt().Require();
                c.SpellBuffRemoveStacks(
                    target: target,
                    buffName: buffName,
                    attacker: attacker,
                    numStacks: numStacks
                    );
                return 0;
            }
        }

        public sealed class BBTeleportToPoint : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var x = p.GetInVarTableOrBlock("XVarTable", "XVar", "X", true).AsFloat().Require();
                var y = p.GetInVarTableOrBlock("YVarTable", "YVar", "Y", true).AsFloat().Require();
                var z = p.GetInVarTableOrBlock("ZVarTable", "ZVar", "Z", true).AsFloat().Require();
                c.BBTeleportToPoint(
                    owner: p.GetInVar("OwnerVar").AsUnit(),
                    position: new Vector3(x, y, z)
                    );
                return 0;
            }
        }

        public sealed class BBTimeChannelTickExecute : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                p.GetBBParam(out float accumTime, "AccumTime", require: true);
                p.GetBBParam(out float tickTime, "TimeTick", require: true);
                if (accumTime >= 0)
                {
                    p.PassThrough["AccumTime"] = -tickTime;
                    p.Exec(c);
                }
                return 0;
            }
        }

        public sealed class BBWhile : BBFunction
        {
            public override int Call(IContext c, Params p)
            {
                var func = p.GetInBlock("CompareOp") as BBOpCO;
                try
                {
                    for (; ; )
                    {
                        var result = func.Require().Call(
                            c,
                            left: p.GetInVarTableOrBlock("Src1VarTable", "Src1Var", "Value1"),
                            right: p.GetInVarTableOrBlock("Src2VarTable", "Src2Var", "Value2")
                            );
                        if (!result)
                        {
                            break;
                        }
                        p.Exec(c);
                    }
                }
                catch (BreakLoop)
                {
                }
                return 0;
            }
        }
    }
}