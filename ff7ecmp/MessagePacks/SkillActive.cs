using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillActive
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 SkillBaseId { get; set; }
        [Key(2)] public System.Int64 ResourceId { get; set; }
        [Key(3)] public System.Int32 Cost { get; set; }
    }
}
