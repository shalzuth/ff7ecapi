using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class WeaponRarityReleaseSkill
    {
        [Key(0)] public System.Int64 WeaponRarityId { get; set; }
        [Key(1)] public System.Int32 ReleaseCount { get; set; }
        [Key(2)] public System.Int32 AddPassiveSkillPoint0 { get; set; }
        [Key(3)] public System.Int32 AddPassiveSkillPoint1 { get; set; }
    }
}
