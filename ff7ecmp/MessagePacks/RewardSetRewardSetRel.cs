using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class RewardSetRewardSetRel
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 RewardSetId1 { get; set; }
        [Key(2)] public System.Int64 RewardSetId2 { get; set; }
        [Key(3)] public System.Int32 LotCount { get; set; }
        [Key(4)] public System.Int32 CountCoefficient { get; set; }
    }
}
