using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EventStoryLevel
    {
        [Key(0)] public System.Int64 EventStoryLevelGroupId { get; set; }
        [Key(1)] public System.Int64 Level { get; set; }
        [Key(2)] public System.Int64 RequiredExp { get; set; }
    }
}
