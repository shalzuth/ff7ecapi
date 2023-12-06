using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Enemy
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ResourceId { get; set; }
        [Key(2)] public System.Int32 BaseCharacterExp { get; set; }
        [Key(3)] public System.Int32 BaseUserExp { get; set; }
        [Key(4)] public System.Int32 BaseGil { get; set; }
        [Key(5)] public System.Int64 NameLanguageId { get; set; }
        [Key(6)] public System.String BgmCueName { get; set; }
        [Key(7)] public System.Int32 HpCoefficient { get; set; }
        [Key(8)] public System.Int32 LbHpCoefficient { get; set; }
        [Key(9)] public System.Int32 PhysicalAttackCoefficient { get; set; }
        [Key(10)] public System.Int32 MagicalAttackCoefficient { get; set; }
        [Key(11)] public System.Int32 PhysicalDefenseCoefficient { get; set; }
        [Key(12)] public System.Int32 MagicalDefenseCoefficient { get; set; }
        [Key(13)] public System.Int32 HealingPowerCoefficient { get; set; }
        [Key(14)] public System.Int32 BaseCriticalPermil { get; set; }
        [Key(15)] public System.Int64 EnemyLevelParameterBaseGroupId { get; set; }
        [Key(16)] public System.Int64 EnemyLevelConstantGroupId { get; set; }
        [Key(17)] public System.Int64 ResistBuffDebuffId { get; set; }
        [Key(18)] public System.Int64 ResistDamageId { get; set; }
        [Key(19)] public System.Int64 ResistElementId { get; set; }
        [Key(20)] public System.Int64 ResistStatusConditionId { get; set; }
    }
}
