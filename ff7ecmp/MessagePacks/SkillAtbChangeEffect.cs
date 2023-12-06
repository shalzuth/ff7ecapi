using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillAtbChangeEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 SkillAtbChangeEffectType { get; set; }
        [Key(2)] public System.Int32 Value { get; set; }
    }
}
