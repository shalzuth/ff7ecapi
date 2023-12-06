using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillPassiveLevel
    {
        [Key(0)] public System.Int64 PassiveSkillId { get; set; }
        [Key(1)] public System.Int32 Level { get; set; }
        [Key(2)] public System.Int32 PassivePoint { get; set; }
    }
}
