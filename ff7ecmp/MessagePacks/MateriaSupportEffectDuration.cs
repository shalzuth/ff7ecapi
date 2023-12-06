using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaSupportEffectDuration
    {
        [Key(0)] public System.Int64 MateriaSupportEffectId { get; set; }
        [Key(1)] public System.Int32 DuplicationDurationSec { get; set; }
        [Key(2)] public System.Int32 EffectDurationSec { get; set; }
        [Key(3)] public System.Int32 DuplicationDurationCoefficient { get; set; }
        [Key(4)] public System.Int32 EffectDurationCoefficient { get; set; }
    }
}
