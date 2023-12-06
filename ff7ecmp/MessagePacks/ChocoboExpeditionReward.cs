using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ChocoboExpeditionReward
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 NormalRewardSetId { get; set; }
        [Key(2)] public System.Int64 RareRewardSetId { get; set; }
        [Key(3)] public System.Int64 AdventureRewardSetId { get; set; }
    }
}
