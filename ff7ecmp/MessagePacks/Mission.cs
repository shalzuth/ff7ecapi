using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Mission
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 MissionSetId { get; set; }
        [Key(2)] public System.Int64 MissionSetIdx { get; set; }
        [Key(3)] public System.Int32 AutoMissionCountType { get; set; }
        [Key(4)] public System.Int32 MissionType { get; set; }
        [Key(5)] public System.Int64 TargetId1 { get; set; }
        [Key(6)] public System.Int64 TargetId2 { get; set; }
        [Key(7)] public System.Int64 TargetId3 { get; set; }
        [Key(8)] public System.Int64 TargetValue { get; set; }
        [Key(9)] public System.Int64 RewardSetId { get; set; }
        [Key(10)] public System.Int64 OrderNo { get; set; }
        [Key(11)] public System.Int64 BonusPoint { get; set; }
        [Key(12)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(13)] public System.Int64 OpenConditionSetId { get; set; }
        [Key(14)] public System.Int64 LockConditionSetId { get; set; }
        [Key(15)] public System.Int32 TransitionType { get; set; }
        [Key(16)] public System.Int64 TransitionId { get; set; }
        [Key(17)] public System.Int64 ResourceId { get; set; }
        [Key(18)] public System.Int64 NameTemplateLanguageId { get; set; }
        [Key(19)] public System.Int64 DescriptionTemplateLanguageId { get; set; }
        [Key(20)] public System.Int64 SupplyConsumptionSetId { get; set; }
        [Key(21)] public System.Boolean IsRefresh { get; set; }
    }
}
