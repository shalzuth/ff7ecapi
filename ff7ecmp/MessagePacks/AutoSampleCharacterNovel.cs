using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AutoSampleCharacterNovel
    {
        [Key(0)] public System.Int64 CharacterId { get; set; }
        [Key(1)] public System.Int64 NovelResourceId { get; set; }
    }
}
