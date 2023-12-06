using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillBaseLevel
    {
        [Key(0)] public System.Int64 SkillBaseId { get; set; }
        [Key(1)] public System.Int32 MaxLevel { get; set; }
        [Key(2)] public System.Int64 SkillEffectGroupId { get; set; }
    }
}
