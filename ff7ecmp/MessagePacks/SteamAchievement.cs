using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SteamAchievement
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 AchievementConditionSetId { get; set; }
        [Key(2)] public System.String SteamApiName { get; set; }
    }
}
