using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class TutorialPopupGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 TutorialPopupType { get; set; }
        [Key(2)] public System.Int32 TransitionType { get; set; }
        [Key(3)] public System.Int64 TransitionId { get; set; }
    }
}
