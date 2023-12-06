using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillDamageEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 AttackType { get; set; }
        [Key(2)] public System.Int32 ElementType { get; set; }
        [Key(3)] public System.Int32 SkillHealType { get; set; }
        [Key(4)] public System.Int32 SkillDamageType { get; set; }
        [Key(5)] public System.Int32 MinDamageCoefficient { get; set; }
        [Key(6)] public System.Int32 MaxDamageCoefficient { get; set; }
        [Key(7)] public System.Int64 SkillAnotherDungeonReduceMaxHpId { get; set; }
    }
}
