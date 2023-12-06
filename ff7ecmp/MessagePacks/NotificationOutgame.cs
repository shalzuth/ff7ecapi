using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class NotificationOutgame
    {
        [Key(0)] public System.Int64 NotificationOutgameGroupId { get; set; }
        [Key(1)] public System.Int32 Seq { get; set; }
        [Key(2)] public System.Int64 ConditionSetId { get; set; }
        [Key(3)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(4)] public System.Int32 NotificationType { get; set; }
        [Key(5)] public System.Int32 TransitionType { get; set; }
        [Key(6)] public System.Int64 TransitionId { get; set; }
    }
}
