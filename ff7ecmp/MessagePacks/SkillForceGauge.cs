using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillForceGauge
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 InitialValue { get; set; }
        [Key(2)] public System.Int32 MaxValue { get; set; }
        [Key(3)] public System.Int32 TimeChangeValue { get; set; }
        [Key(4)] public System.Boolean IsStopMin { get; set; }
        [Key(5)] public System.Boolean IsStopMax { get; set; }
        [Key(6)] public System.Int64 NameLanguageId { get; set; }
        [Key(7)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(8)] public System.Int64 SkillForceGaugeChainEffectId { get; set; }
        [Key(9)] public System.Int64 SkillForceGaugeParameterEffectGroupId { get; set; }
        [Key(10)] public System.Int64 SkillForceGaugeTakenDamageEffectGroupId { get; set; }
        [Key(11)] public System.Int32 TutorialStepType { get; set; }
    }
}
