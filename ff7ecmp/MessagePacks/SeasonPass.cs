using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SeasonPass
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 SeasonPassStepGroupId { get; set; }
        [Key(2)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(3)] public System.Int64 OpenConditionSetId { get; set; }
        [Key(4)] public System.Int64 LockConditionSetId { get; set; }
        [Key(5)] public System.Int32 LevelProgressMaxCount { get; set; }
        [Key(6)] public System.Int64 ExpiredSendGiftStartDatetime { get; set; }
        [Key(7)] public System.Int64 LevelShopItemId { get; set; }
        [Key(8)] public System.Int64 ExtraShopItemId { get; set; }
        [Key(9)] public System.Int64 TitleLanguageId { get; set; }
        [Key(10)] public System.Int64 NameLanguageId { get; set; }
        [Key(11)] public System.Int64 ResourceId { get; set; }
    }
}
