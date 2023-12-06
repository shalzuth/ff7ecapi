using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AnotherDungeonRank
    {
        [Key(0)] public System.Int64 AnotherDungeonId { get; set; }
        [Key(1)] public System.Int32 RankType { get; set; }
        [Key(2)] public System.Int64 Score { get; set; }
        [Key(3)] public System.Int64 FirstRewardSetId { get; set; }
        [Key(4)] public System.Int64 LapRewardSetId { get; set; }
    }
}
