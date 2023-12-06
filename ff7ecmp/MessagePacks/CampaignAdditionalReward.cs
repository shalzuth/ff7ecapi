using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class CampaignAdditionalReward
    {
        [Key(0)] public System.Int64 CampaignAdditionalRewardGroupId { get; set; }
        [Key(1)] public System.Int64 StaminaThreshold { get; set; }
        [Key(2)] public System.Int64 RewardSetId { get; set; }
    }
}
