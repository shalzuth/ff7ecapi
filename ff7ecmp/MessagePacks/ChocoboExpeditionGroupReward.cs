using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ChocoboExpeditionGroupReward
    {
        [Key(0)] public System.Int64 ChocoboExpeditionGroupId { get; set; }
        [Key(1)] public System.Int32 Idx { get; set; }
        [Key(2)] public System.Int64 RewardId { get; set; }
        [Key(3)] public System.Int32 ChocoboExpeditionRewardType { get; set; }
    }
}
