using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class StoryTitle
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 EntryStoryCharacterGroupId { get; set; }
        [Key(2)] public System.String DisplayName { get; set; }
        [Key(3)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(4)] public System.Int64 LockConditionSetId { get; set; }
        [Key(5)] public System.Int32 OrderNo { get; set; }
        [Key(6)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(7)] public System.Int64 NameLanguageId { get; set; }
        [Key(8)] public System.Int64 SeriesLanguageId { get; set; }
        [Key(9)] public System.Int64 ResourceId { get; set; }
        [Key(10)] public System.Boolean IsSuffixSeriesName { get; set; }
    }
}
