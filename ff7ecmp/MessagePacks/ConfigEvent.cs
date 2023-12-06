using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ConfigEvent
    {
        [Key(0)] public System.Int32 Id { get; set; }
        [Key(1)] public System.Int32 EventClashClearHigherListDisplayCount { get; set; }
        [Key(2)] public System.Int32 EventClashClearListDisplayCount { get; set; }
        [Key(3)] public System.Int32 NotSelectedHomeBackgroundPermil { get; set; }
    }
}
