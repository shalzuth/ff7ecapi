using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class WeaponRarity
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 WeaponId { get; set; }
        [Key(2)] public System.Int32 RarityType { get; set; }
        [Key(3)] public System.Int32 BaseHp { get; set; }
        [Key(4)] public System.Int32 BasePhysicalAttack { get; set; }
        [Key(5)] public System.Int32 BaseMagicalAttack { get; set; }
        [Key(6)] public System.Int32 BasePhysicalDefense { get; set; }
        [Key(7)] public System.Int32 BaseMagicalDefense { get; set; }
        [Key(8)] public System.Int32 BaseHealingPower { get; set; }
        [Key(9)] public System.Int32 GrowthBaseHp { get; set; }
        [Key(10)] public System.Int32 GrowthBasePhysicalAttack { get; set; }
        [Key(11)] public System.Int32 GrowthBaseMagicalAttack { get; set; }
        [Key(12)] public System.Int32 GrowthBasePhysicalDefense { get; set; }
        [Key(13)] public System.Int32 GrowthBaseMagicalDefense { get; set; }
        [Key(14)] public System.Int32 GrowthBaseHealingPower { get; set; }
        [Key(15)] public System.Int64 WeaponSkillId { get; set; }
        [Key(16)] public System.Int32 PassiveSkillPoint0 { get; set; }
        [Key(17)] public System.Int32 PassiveSkillPoint1 { get; set; }
    }
}
