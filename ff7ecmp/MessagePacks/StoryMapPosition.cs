using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class StoryMapPosition
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 StoryMapId { get; set; }
        [Key(2)] public System.Int64 ResourceId { get; set; }
    }
}
