using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BoxGachaReward
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 BoxGachaRewardGroupId { get; set; }
        [Key(2)] public System.Int32 BoxGachaRarityType { get; set; }
        [Key(3)] public System.Int32 OrderNo { get; set; }
        [Key(4)] public System.Int64 MaxDrawableCount { get; set; }
        [Key(5)] public System.Int64 RewardSetId { get; set; }
    }
}
