using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class HelpPopup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 HelpPopupGroupId { get; set; }
        [Key(2)] public System.Int64 Seq { get; set; }
        [Key(3)] public System.Int64 ResourceId { get; set; }
        [Key(4)] public System.Int64 TitleLanguageId { get; set; }
        [Key(5)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(6)] public System.Int64 ConditionSetId { get; set; }
    }
}
