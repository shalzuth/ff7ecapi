using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class TipsGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 TipsGroupType { get; set; }
        [Key(2)] public System.Int64 StoryTitleId { get; set; }
    }
}
