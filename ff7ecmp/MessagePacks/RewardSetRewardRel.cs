using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class RewardSetRewardRel
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 RewardSetId { get; set; }
        [Key(2)] public System.Int64 RewardId { get; set; }
        [Key(3)] public System.Int32 OrderNo { get; set; }
        [Key(4)] public System.Int32 MinCount { get; set; }
        [Key(5)] public System.Int32 MaxCount { get; set; }
        [Key(6)] public System.Boolean IsPickup { get; set; }
    }
}
