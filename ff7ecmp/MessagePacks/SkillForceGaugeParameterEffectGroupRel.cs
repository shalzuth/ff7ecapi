using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillForceGaugeParameterEffectGroupRel
    {
        [Key(0)] public System.Int64 SkillForceGaugeParameterEffectGroupId { get; set; }
        [Key(1)] public System.Int64 SkillForceGaugeParameterEffectId { get; set; }
    }
}
