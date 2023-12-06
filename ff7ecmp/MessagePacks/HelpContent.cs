using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class HelpContent
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 HelpId { get; set; }
        [Key(2)] public System.Int64 TitleLanguageId { get; set; }
        [Key(3)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(4)] public System.Int32 OrderNo { get; set; }
        [Key(5)] public System.Int64 ResourceId { get; set; }
    }
}
