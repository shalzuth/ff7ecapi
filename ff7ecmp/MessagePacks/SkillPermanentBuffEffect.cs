using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillPermanentBuffEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Boolean ResetOnInterrupt { get; set; }
    }
}
