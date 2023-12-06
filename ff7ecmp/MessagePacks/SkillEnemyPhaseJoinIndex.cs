using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillEnemyPhaseJoinIndex
    {
        [Key(0)] public System.Int64 SkillEnemyPhaseJoinIndexGroupId { get; set; }
        [Key(1)] public System.Int32 Idx { get; set; }
        [Key(2)] public System.Boolean HideHudFlag { get; set; }
    }
}
