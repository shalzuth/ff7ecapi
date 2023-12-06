using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillSpecial
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 SkillSpecialType { get; set; }
        [Key(2)] public System.Int64 ContentId { get; set; }
        [Key(3)] public System.Int64 SkillBaseId { get; set; }
        [Key(4)] public System.Int64 ResourceId { get; set; }
    }
}
