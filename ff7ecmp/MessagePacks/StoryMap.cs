using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class StoryMap
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ParentStoryMapId { get; set; }
        [Key(2)] public System.Int32 StoryMapType { get; set; }
        [Key(3)] public System.Int64 ResourceId { get; set; }
    }
}
