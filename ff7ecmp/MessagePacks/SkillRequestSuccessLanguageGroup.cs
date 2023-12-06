using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillRequestSuccessLanguageGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Idx { get; set; }
        [Key(2)] public System.Int64 LanguageId { get; set; }
    }
}
