using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EnemyLevelParameterBase
    {
        [Key(0)] public System.Int64 EnemyLevelParameterBaseGroupId { get; set; }
        [Key(1)] public System.Int64 Level { get; set; }
        [Key(2)] public System.Int32 BaseHp { get; set; }
        [Key(3)] public System.Int32 BaseLbHp { get; set; }
        [Key(4)] public System.Int32 BasePhysicalAttack { get; set; }
        [Key(5)] public System.Int32 BaseMagicalAttack { get; set; }
        [Key(6)] public System.Int32 BasePhysicalDefense { get; set; }
        [Key(7)] public System.Int32 BaseMagicalDefense { get; set; }
        [Key(8)] public System.Int32 BaseHealingPower { get; set; }
        [Key(9)] public System.Int32 CharacterExpCoefficient { get; set; }
        [Key(10)] public System.Int32 UserExpCoefficient { get; set; }
        [Key(11)] public System.Int32 GilCoefficient { get; set; }
        [Key(12)] public System.Int32 CriticalPermilCoefficient { get; set; }
        [Key(13)] public System.Int32 CriticalDamageCoefficient { get; set; }
    }
}
