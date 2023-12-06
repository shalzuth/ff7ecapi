using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillForceGaugeParameterEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 SkillForceGaugeParameterEffectType { get; set; }
        [Key(2)] public System.Int32 ParameterDetailType { get; set; }
        [Key(3)] public System.Int32 MinValuePermil { get; set; }
        [Key(4)] public System.Int32 MaxValuePermil { get; set; }
    }
}
