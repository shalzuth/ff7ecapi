using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class StoryLanguage
    {
        [Key(0)] public System.Int64 LanguageId { get; set; }
    }
}
