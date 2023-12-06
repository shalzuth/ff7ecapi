using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillEffectDescriptionGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Seq { get; set; }
        [Key(2)] public System.Int64 SkillEffectDescriptionId { get; set; }
    }
}
