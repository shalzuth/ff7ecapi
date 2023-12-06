using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillSpecialCombo
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Count { get; set; }
        [Key(2)] public System.Int32 SkillBaseAttackType { get; set; }
        [Key(3)] public System.Int32 DamageCoefficient { get; set; }
    }
}
