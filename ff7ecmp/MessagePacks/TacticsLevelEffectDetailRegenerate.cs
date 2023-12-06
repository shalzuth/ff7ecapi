using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class TacticsLevelEffectDetailRegenerate
    {
        [Key(0)] public System.Int64 TacticsLevelEffectId { get; set; }
        [Key(1)] public System.Int32 EffectCoefficient { get; set; }
        [Key(2)] public System.Int32 FixedValue { get; set; }
        [Key(3)] public System.Int32 InvokeCycleSec { get; set; }
    }
}
