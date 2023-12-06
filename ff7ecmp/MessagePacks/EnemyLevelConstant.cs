using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EnemyLevelConstant
    {
        [Key(0)] public System.Int64 EnemyLevelConstantGroupId { get; set; }
        [Key(1)] public System.Int64 Level { get; set; }
        [Key(2)] public System.Int64 ResourceId { get; set; }
        [Key(3)] public System.Int64 EnemySkillLevelId { get; set; }
        [Key(4)] public System.Int64 BossCautionLanguageId { get; set; }
    }
}
