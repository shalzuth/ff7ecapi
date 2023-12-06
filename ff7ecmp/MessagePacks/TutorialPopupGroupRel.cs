using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class TutorialPopupGroupRel
    {
        [Key(0)] public System.Int64 TutorialId { get; set; }
        [Key(1)] public System.Int64 TutorialPopupGroupId { get; set; }
        [Key(2)] public System.Int64 Seq { get; set; }
    }
}
