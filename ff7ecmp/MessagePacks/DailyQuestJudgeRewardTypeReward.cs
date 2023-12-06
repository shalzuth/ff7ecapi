using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DailyQuestJudgeRewardTypeReward
    {
        [Key(0)] public System.Int32 JudgeRewardType { get; set; }
        [Key(1)] public System.Int32 Gil { get; set; }
    }
}
