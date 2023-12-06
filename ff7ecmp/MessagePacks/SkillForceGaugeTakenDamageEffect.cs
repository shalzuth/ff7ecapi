using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillForceGaugeTakenDamageEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 SkillForceGaugeTakenDamageCalcType { get; set; }
        [Key(2)] public System.Int32 SkillForceGaugeTakenDamageEffectType { get; set; }
        [Key(3)] public System.Int32 ParameterDetailType { get; set; }
        [Key(4)] public System.Int32 EffectValue { get; set; }
    }
}
