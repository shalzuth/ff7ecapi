using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EventClashBattleRewardRank
    {
        [Key(0)] public System.Int64 EventClashBattleRewardRankGroupId { get; set; }
        [Key(1)] public System.Int64 Threshold { get; set; }
        [Key(2)] public System.Int64 RewardSetId { get; set; }
        [Key(3)] public System.Int64 ResourceId { get; set; }
    }
}
