using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class WeaponUpgradeParameter
    {
        [Key(0)] public System.Int64 WeaponUpgradeParameterGroupId { get; set; }
        [Key(1)] public System.Int32 WeaponUpgradeType { get; set; }
        [Key(2)] public System.Int32 UpgradeCount { get; set; }
        [Key(3)] public System.Int32 HpAddCoefficient { get; set; }
        [Key(4)] public System.Int32 PhysicalAttackAddCoefficient { get; set; }
        [Key(5)] public System.Int32 MagicalAddCoefficient { get; set; }
        [Key(6)] public System.Int32 PhysicalDefenseAddCoefficient { get; set; }
        [Key(7)] public System.Int32 MagicalDefenseAddCoefficient { get; set; }
        [Key(8)] public System.Int32 HealingPowerAddCoefficient { get; set; }
    }
}
