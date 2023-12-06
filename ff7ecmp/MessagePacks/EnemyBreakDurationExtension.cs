using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EnemyBreakDurationExtension
    {
        [Key(0)] public System.Int64 EnemyBreakDurationExtensionGroupId { get; set; }
        [Key(1)] public System.Int32 RemainingPhaseTimePermil { get; set; }
        [Key(2)] public System.Int32 Duration { get; set; }
    }
}
