using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillEffectDescription
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 SkillEffectDescriptionType { get; set; }
        [Key(2)] public System.Int64 DescriptionLanguageId { get; set; }
    }
}
