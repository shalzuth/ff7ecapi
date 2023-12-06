using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Interjection
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 MovieResourceId { get; set; }
        [Key(2)] public System.Int64 LayoutResourceId { get; set; }
        [Key(3)] public System.Int64 ImageResourceId { get; set; }
        [Key(4)] public System.Int64 Priority { get; set; }
        [Key(5)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(6)] public System.Int64 VisibleOpenConditionSetId { get; set; }
        [Key(7)] public System.Int32 TransitionType { get; set; }
        [Key(8)] public System.Int64 TransitionId { get; set; }
        [Key(9)] public System.Boolean EnableHomeBgm { get; set; }
        [Key(10)] public System.Int64 ButtonLanguageId { get; set; }
        [Key(11)] public System.Int64 ResetId { get; set; }
        [Key(12)] public System.Int64 MaxDisplayCount { get; set; }
    }
}
