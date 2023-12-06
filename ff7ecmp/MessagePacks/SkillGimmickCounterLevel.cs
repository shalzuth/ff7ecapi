using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillGimmickCounterLevel
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 CounterLevel { get; set; }
        [Key(2)] public System.Int64 SkillBaseId { get; set; }
        [Key(3)] public System.Int32 AttackCount { get; set; }
    }
}
