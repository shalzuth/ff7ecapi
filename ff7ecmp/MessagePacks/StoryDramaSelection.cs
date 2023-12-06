using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class StoryDramaSelection
    {
        [Key(0)] public System.Int64 Id { get; set; }
    }
}
