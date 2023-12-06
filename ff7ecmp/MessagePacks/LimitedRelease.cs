using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class LimitedRelease
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 NameLanguageId { get; set; }
        [Key(2)] public System.Int32 LimitedReleaseTriggerSourceType { get; set; }
        [Key(3)] public System.Int32 Seq { get; set; }
        [Key(4)] public System.Int64 ReleaseConditionSetId { get; set; }
        [Key(5)] public System.Int32 OrderNo { get; set; }
        [Key(6)] public System.Int64 ResourceId { get; set; }
        [Key(7)] public System.Int32 LimitedReleaseTargetType { get; set; }
        [Key(8)] public System.Int64 TargetId { get; set; }
        [Key(9)] public System.Int64 ReleaseDurationMinute { get; set; }
        [Key(10)] public System.Int32 LimitedReleaseDirectionType { get; set; }
        [Key(11)] public System.Int64 LimitedReleaseGroupId { get; set; }
    }
}
