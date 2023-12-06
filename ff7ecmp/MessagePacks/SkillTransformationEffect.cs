using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillTransformationEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 EnemyId { get; set; }
        [Key(2)] public System.Int64 Level { get; set; }
    }
}
