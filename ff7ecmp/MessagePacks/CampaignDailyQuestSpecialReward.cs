using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class CampaignDailyQuestSpecialReward
    {
        [Key(0)] public System.Int64 CampaignDailyQuestSpecialRewardGroupId { get; set; }
        [Key(1)] public System.Int32 DailyQuestType { get; set; }
        [Key(2)] public System.Int32 DifficultyLevel { get; set; }
        [Key(3)] public System.Int64 RewardSetId { get; set; }
    }
}
