using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class HelpCategory
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 TitleLanguageId { get; set; }
        [Key(2)] public System.Int32 OrderNo { get; set; }
    }
}
