using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Weapon
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 WeaponType { get; set; }
        [Key(2)] public System.Int64 CharacterId { get; set; }
        [Key(3)] public System.Int64 WeaponLevelGroupId { get; set; }
        [Key(4)] public System.Int32 BaseExp { get; set; }
        [Key(5)] public System.Int32 EnhanceConsumptionGilCoefficient { get; set; }
        [Key(6)] public System.Int64 WeaponMateriaSupportId0 { get; set; }
        [Key(7)] public System.Int64 WeaponMateriaSupportId1 { get; set; }
        [Key(8)] public System.Int64 WeaponMateriaSupportId2 { get; set; }
        [Key(9)] public System.Int64 PassiveSkillId0 { get; set; }
        [Key(10)] public System.Int64 PassiveSkillId1 { get; set; }
        [Key(11)] public System.Int64 WeaponRaritySettingGroupId { get; set; }
        [Key(12)] public System.Int64 WeaponReleaseSettingGroupId { get; set; }
        [Key(13)] public System.Int64 WeaponReleaseParameterGroupId { get; set; }
        [Key(14)] public System.Int64 WeaponUpgradeParameterGroupId { get; set; }
        [Key(15)] public System.Int64 WeaponUpgradeConsumptionGroupId { get; set; }
        [Key(16)] public System.Int64 ResourceId { get; set; }
        [Key(17)] public System.Int64 NameLanguageId { get; set; }
        [Key(18)] public System.Int64 WeaponMedalItemId { get; set; }
    }
}
