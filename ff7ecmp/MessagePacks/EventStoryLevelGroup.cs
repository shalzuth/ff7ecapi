using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EventStoryLevelGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
    }
}
