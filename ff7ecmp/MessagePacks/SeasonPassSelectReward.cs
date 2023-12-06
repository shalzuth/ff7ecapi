using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SeasonPassSelectReward
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 SeasonPassSelectRewardGroupId { get; set; }
        [Key(2)] public System.Int64 RewardSetId { get; set; }
    }
}
