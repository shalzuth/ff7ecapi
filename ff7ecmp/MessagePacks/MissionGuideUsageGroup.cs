using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MissionGuideUsageGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 UsageLanguageId { get; set; }
    }
}
