using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MissionGuideUsage
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 MissionGuideUsageGroupId { get; set; }
        [Key(2)] public System.Int32 MissionType { get; set; }
    }
}
