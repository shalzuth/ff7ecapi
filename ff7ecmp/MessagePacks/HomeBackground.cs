using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class HomeBackground
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(2)] public System.Int64 NameLanguageId { get; set; }
        [Key(3)] public System.Int32 Weight { get; set; }
        [Key(4)] public System.Int64 ResourceId { get; set; }
        [Key(5)] public System.Int32 ItemRarityType { get; set; }
        [Key(6)] public System.Int64 DescriptionLanguageId { get; set; }
    }
}
