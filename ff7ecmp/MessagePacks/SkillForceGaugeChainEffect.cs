using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillForceGaugeChainEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 DurationMsec { get; set; }
        [Key(2)] public System.Int32 EffectCoefficient { get; set; }
        [Key(3)] public System.Int32 MaxEffectCoefficient { get; set; }
    }
}
