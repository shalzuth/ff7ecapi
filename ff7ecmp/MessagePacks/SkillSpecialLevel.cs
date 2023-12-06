using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillSpecialLevel
    {
        [Key(0)] public System.Int64 SkillSpecialId { get; set; }
        [Key(1)] public System.Int32 Level { get; set; }
        [Key(2)] public System.Int32 Cost { get; set; }
        [Key(3)] public System.Int32 DamageCoefficient { get; set; }
        [Key(4)] public System.Int64 SkillEffectGroupId { get; set; }
    }
}
