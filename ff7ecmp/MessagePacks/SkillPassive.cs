using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillPassive
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 PassiveSkillEffectGroupId { get; set; }
        [Key(2)] public System.Int64 ResourceId { get; set; }
        [Key(3)] public System.Int32 PassiveSkillCategoryType { get; set; }
        [Key(4)] public System.Int64 NameLanguageId { get; set; }
    }
}
