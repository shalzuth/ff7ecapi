using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class WeaponRaritySetting
    {
        [Key(0)] public System.Int64 WeaponRaritySettingGroupId { get; set; }
        [Key(1)] public System.Int32 RarityType { get; set; }
        [Key(2)] public System.Int64 NextRarityWeaponMedal { get; set; }
    }
}
