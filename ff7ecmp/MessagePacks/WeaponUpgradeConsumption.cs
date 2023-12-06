using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class WeaponUpgradeConsumption
    {
        [Key(0)] public System.Int64 WeaponUpgradeConsumptionGroupId { get; set; }
        [Key(1)] public System.Int32 WeaponUpgradeType { get; set; }
        [Key(2)] public System.Int32 UpgradeCount { get; set; }
        [Key(3)] public System.Int32 ConsumptionWeaponMedal { get; set; }
        [Key(4)] public System.Int32 ConsumptionGil { get; set; }
        [Key(5)] public System.Int64 WeaponIngredientGroupId { get; set; }
    }
}
