using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillRelocationReadyEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 InvokeSkilBaseId { get; set; }
    }
}
