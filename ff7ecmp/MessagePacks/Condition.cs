using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Condition
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 ConditionType { get; set; }
        [Key(2)] public System.Int64 TargetId { get; set; }
        [Key(3)] public System.Int64 TargetValue { get; set; }
        [Key(4)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(5)] public System.Int64 StartDatetime { get; set; }
        [Key(6)] public System.Int64 EndDatetime { get; set; }
        [Key(7)] public System.Int32 CycleType { get; set; }
        [Key(8)] public System.Int64 ParentLength { get; set; }
        [Key(9)] public System.Int64 ChildLength { get; set; }
        [Key(10)] public System.Int64 ChildOffsetLength { get; set; }
        [Key(11)] public System.Int32 UserCountType { get; set; }
        [Key(12)] public System.Int64 TargetId1 { get; set; }
        [Key(13)] public System.Int64 TargetId2 { get; set; }
        [Key(14)] public System.Int64 TargetId3 { get; set; }
        [Key(15)] public System.Int64 Min { get; set; }
        [Key(16)] public System.Int64 Max { get; set; }
        [Key(17)] public System.Int32 UserTimeType { get; set; }
        [Key(18)] public System.Int64 TargetDurationMinute { get; set; }
    }
}
