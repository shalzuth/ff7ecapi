using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DailyReward
    {
        [Key(0)] public System.Int64 DailyRewardGroupId { get; set; }
        [Key(1)] public System.Int32 OffsetDay { get; set; }
        [Key(2)] public System.Int64 RewardSetId { get; set; }
    }
}
