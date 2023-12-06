using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AutoRewardHint
    {
        [Key(0)] public System.Int64 RewardId { get; set; }
        [Key(1)] public System.Int32 RewardHintType { get; set; }
        [Key(2)] public System.Int64 ReferencePk1 { get; set; }
        [Key(3)] public System.Int32 TransitionType { get; set; }
        [Key(4)] public System.Int64 TransitionId { get; set; }
        [Key(5)] public System.Int64 OrderNo { get; set; }
    }
}
