using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GrowthBoardNode
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 PremiseNodeId { get; set; }
        [Key(2)] public System.Int64 LockConditionSetId { get; set; }
        [Key(3)] public System.Int64 SkillSpecialId { get; set; }
        [Key(4)] public System.Int32 GrantValueType { get; set; }
        [Key(5)] public System.Int32 HpNodeStatusValue { get; set; }
        [Key(6)] public System.Int32 PhysicalAttackNodeStatusValue { get; set; }
        [Key(7)] public System.Int32 MagicalAttackNodeStatusValue { get; set; }
        [Key(8)] public System.Int32 PhysicalDefenseNodeStatusValue { get; set; }
        [Key(9)] public System.Int32 MagicalDefenseNodeStatusValue { get; set; }
        [Key(10)] public System.Int32 HealingPowerNodeStatusValue { get; set; }
        [Key(11)] public System.Int32 SpecialGaugeNodeStatusValue { get; set; }
        [Key(12)] public System.Int32 SummonEnhancePowerNodeStatusValue { get; set; }
        [Key(13)] public System.Int32 SummonDownCostNodeStatusValue { get; set; }
        [Key(14)] public System.Int32 Cost { get; set; }
        [Key(15)] public System.Int64 GrowthBoardGroupId { get; set; }
        [Key(16)] public System.Int32 GrowthBoardGroupIdx { get; set; }
        [Key(17)] public System.Int32 BoardNodeIconType { get; set; }
        [Key(18)] public System.Int64 PositionId { get; set; }
        [Key(19)] public System.Int64 ConsumptionSetId { get; set; }
    }
}
