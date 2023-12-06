using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillBase
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 BaseAttackType { get; set; }
        [Key(2)] public System.Int32 ElementType { get; set; }
        [Key(3)] public System.Int32 SpecialGaugeCoefficient { get; set; }
        [Key(4)] public System.Int64 SkillEffectGroupId { get; set; }
        [Key(5)] public System.Int64 NameLanguageId { get; set; }
        [Key(6)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(7)] public System.Int64 SkillBaseGroupId { get; set; }
        [Key(8)] public System.Int64 BattleNameLanguageId { get; set; }
    }
}
