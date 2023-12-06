using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EventBase
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 EventType { get; set; }
        [Key(2)] public System.Int32 OrderNo { get; set; }
        [Key(3)] public System.Int64 ShopGroupId { get; set; }
        [Key(4)] public System.Int64 EventScenarioSectionId { get; set; }
        [Key(5)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(6)] public System.Int64 LockConditionSetId { get; set; }
        [Key(7)] public System.Int64 OpenConditionSetId { get; set; }
        [Key(8)] public System.Int32 ResetMaxBattleWinCount { get; set; }
        [Key(9)] public System.Int64 BattleWinResetId { get; set; }
        [Key(10)] public System.Int64 NameLanguageId { get; set; }
        [Key(11)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(12)] public System.Int64 IconResourceId { get; set; }
        [Key(13)] public System.Int64 EventClashId { get; set; }
        [Key(14)] public System.Int64 EventDisplayItemGroupId { get; set; }
        [Key(15)] public System.Int64 EventStoryLevelGroupId { get; set; }
        [Key(16)] public System.Int64 BoxGachaGroupId { get; set; }
        [Key(17)] public System.Int64 StoryChapterId { get; set; }
        [Key(18)] public System.Int64 BossNameLanguageId { get; set; }
        [Key(19)] public System.Int64 AnnouncementId { get; set; }
        [Key(20)] public System.Int64 EventDetailId { get; set; }
    }
}
