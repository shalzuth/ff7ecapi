using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EventScoreDungeon
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 AnotherAreaId { get; set; }
        [Key(2)] public System.Int64 EventBaseId { get; set; }
        [Key(3)] public System.Int64 RankingGroupId { get; set; }
        [Key(4)] public System.Int64 EventScoreDungeonScoreGroupId { get; set; }
        [Key(5)] public System.Int32 GroupCount { get; set; }
        [Key(6)] public System.Int64 FixScoreDatetime { get; set; }
        [Key(7)] public System.Int64 FixRankingDatetime { get; set; }
        [Key(8)] public System.Int64 ExpiredSendGiftStartDatetime { get; set; }
        [Key(9)] public System.Int64 ExpiredSendGiftEndDatetime { get; set; }
        [Key(10)] public System.Int64 EntryConditionSetId { get; set; }
    }
}
