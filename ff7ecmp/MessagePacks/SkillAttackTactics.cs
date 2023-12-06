using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillAttackTactics
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 TacticsType { get; set; }
        [Key(2)] public System.Int64 SkillAttackId { get; set; }
    }
}
