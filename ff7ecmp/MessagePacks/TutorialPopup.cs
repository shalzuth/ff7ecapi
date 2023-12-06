using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class TutorialPopup
    {
        [Key(0)] public System.Int64 TutorialPopupGroupId { get; set; }
        [Key(1)] public System.Int64 Seq { get; set; }
        [Key(2)] public System.Int64 ResourceId { get; set; }
        [Key(3)] public System.Int64 TitleLanguageId { get; set; }
        [Key(4)] public System.Int64 DescriptionLanguageId { get; set; }
    }
}
