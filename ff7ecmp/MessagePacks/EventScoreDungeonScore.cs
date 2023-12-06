using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EventScoreDungeonScore
    {
        [Key(0)] public System.Int64 EventScoreDungeonScoreGroupId { get; set; }
        [Key(1)] public System.Int32 Idx { get; set; }
        [Key(2)] public System.Int64 ScoreThreshold { get; set; }
        [Key(3)] public System.Int64 RewardSetId { get; set; }
    }
}
