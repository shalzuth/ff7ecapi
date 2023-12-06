using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MissionGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 MissionGroupType { get; set; }
        [Key(2)] public System.Int64 MissionBonusGroupId { get; set; }
        [Key(3)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(4)] public System.Int64 OpenConditionSetId { get; set; }
        [Key(5)] public System.Int64 LockConditionSetId { get; set; }
        [Key(6)] public System.Int64 ResourceId { get; set; }
        [Key(7)] public System.Int64 NameLanguageId { get; set; }
        [Key(8)] public System.Int64 ExpiredSendGiftStartDatetime { get; set; }
        [Key(9)] public System.Int64 ResetId { get; set; }
        [Key(10)] public System.Int64 SpecialTargetId { get; set; }
        [Key(11)] public System.Int64 RewardSkillSpecialId { get; set; }
        [Key(12)] public System.Int64 RewardSummonId { get; set; }
        [Key(13)] public System.Int64 SeasonPassItemId { get; set; }
        [Key(14)] public System.Int64 ExtraMissionBonusGroupId { get; set; }
        [Key(15)] public System.Int64 SeasonPassId { get; set; }
        [Key(16)] public System.Int64 IconResourceId { get; set; }
        [Key(17)] public System.Int32 OrderNo { get; set; }
    }
}
