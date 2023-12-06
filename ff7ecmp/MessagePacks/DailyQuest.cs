using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DailyQuest
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 DifficultyLevel { get; set; }
        [Key(2)] public System.Int32 DailyQuestType { get; set; }
        [Key(3)] public System.Int32 BaseGil { get; set; }
        [Key(4)] public System.Int64 NameLanguageId { get; set; }
        [Key(5)] public System.Int64 BattleId { get; set; }
        [Key(6)] public System.Int64 DailyQuestJudgeRewardGroupId { get; set; }
        [Key(7)] public System.Int64 DailyQuestJudgeRewardLotGroupId { get; set; }
        [Key(8)] public System.Int32 DropRewardCount { get; set; }
        [Key(9)] public System.Int64 RewardSetId { get; set; }
        [Key(10)] public System.Boolean IsSpecial { get; set; }
    }
}
