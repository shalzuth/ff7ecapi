using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillForceGaugeTakenDamageEffectGroupRel
    {
        [Key(0)] public System.Int64 SkillForceGaugeTakenDamageEffectGroupId { get; set; }
        [Key(1)] public System.Int64 SkillForceGaugeTakenDamageEffectId { get; set; }
    }
}
