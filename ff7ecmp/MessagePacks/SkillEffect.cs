using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 TargetType { get; set; }
        [Key(2)] public System.Int32 SkillEffectType { get; set; }
        [Key(3)] public System.Int64 SkillEffectDetailId { get; set; }
        [Key(4)] public System.Int32 MinTriggerPermil { get; set; }
        [Key(5)] public System.Int32 MaxTriggerPermil { get; set; }
        [Key(6)] public System.Int32 TriggerType { get; set; }
        [Key(7)] public System.Int64 TriggerConditionId { get; set; }
        [Key(8)] public System.Int32 ConditionTargetType { get; set; }
        [Key(9)] public System.Boolean IsInvertTriggerCondition { get; set; }
        [Key(10)] public System.Int32 PenetrationPermil { get; set; }
        [Key(11)] public System.Int64 SkillEffectDescriptionGroupId { get; set; }
    }
}
