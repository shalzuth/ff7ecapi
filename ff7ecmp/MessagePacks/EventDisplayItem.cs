using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EventDisplayItem
    {
        [Key(0)] public System.Int64 EventDisplayItemGroupId { get; set; }
        [Key(1)] public System.Int32 Idx { get; set; }
        [Key(2)] public System.Int64 ItemId { get; set; }
        [Key(3)] public System.Int64 DisplayConditionSetId { get; set; }
    }
}
