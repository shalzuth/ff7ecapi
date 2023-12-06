using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillAdditionalEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 SkillAdditionalType { get; set; }
        [Key(2)] public System.Boolean IsRandom { get; set; }
        [Key(3)] public System.Int32 MinValue { get; set; }
        [Key(4)] public System.Int32 MaxValue { get; set; }
    }
}
