using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class StorySection
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 StoryChapterId { get; set; }
        [Key(2)] public System.Int32 OrderNo { get; set; }
        [Key(3)] public System.Int64 StoryMapPositionId { get; set; }
        [Key(4)] public System.Int64 NameLanguageId { get; set; }
        [Key(5)] public System.Int32 StorySectionType { get; set; }
        [Key(6)] public System.Int32 SectionOrderNo { get; set; }
    }
}
