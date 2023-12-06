using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class TipsFixStory
    {
        [Key(0)] public System.Int64 StoryEpisodeId { get; set; }
        [Key(1)] public System.Int64 FixTipsId { get; set; }
        [Key(2)] public System.Boolean IsFirstFix { get; set; }
    }
}
