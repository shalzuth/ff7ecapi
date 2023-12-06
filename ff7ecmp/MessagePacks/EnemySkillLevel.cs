using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EnemySkillLevel
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 SkillEnemyId { get; set; }
        [Key(2)] public System.Int32 SkillLevel { get; set; }
    }
}
