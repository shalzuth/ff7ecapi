using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleRank
    {
        [Key(0)] public System.Int64 BattleRankGroupId { get; set; }
        [Key(1)] public System.Int32 RankType { get; set; }
        [Key(2)] public System.Int64 LapRewardSetId { get; set; }
        [Key(3)] public System.Int32 LapRewardCount { get; set; }
    }
}
