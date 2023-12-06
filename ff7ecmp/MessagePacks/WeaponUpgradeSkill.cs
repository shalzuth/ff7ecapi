using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class WeaponUpgradeSkill
    {
        [Key(0)] public System.Int64 WeaponId { get; set; }
        [Key(1)] public System.Int32 WeaponUpgradeType { get; set; }
        [Key(2)] public System.Int32 UpgradeCount { get; set; }
        [Key(3)] public System.Int64 WeaponSkillId { get; set; }
        [Key(4)] public System.Int32 AddPassiveSkillPoint0 { get; set; }
        [Key(5)] public System.Int32 AddPassiveSkillPoint1 { get; set; }
    }
}
