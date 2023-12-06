using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillPassiveEffectLevel
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Level { get; set; }
        [Key(2)] public System.Int32 EffectValue { get; set; }
        [Key(3)] public System.Int32 EffectCoefficient { get; set; }
        [Key(4)] public System.Int32 PassiveSkillTriggerType { get; set; }
        [Key(5)] public System.Int64 PassiveSkillFilterGroupId { get; set; }
        [Key(6)] public System.Int64 DescriptionLanguageId { get; set; }
    }
}
