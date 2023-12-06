using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class StoryDisplayEnemyGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 EnemyId0 { get; set; }
        [Key(2)] public System.Int64 EnemyId1 { get; set; }
        [Key(3)] public System.Int64 EnemyId2 { get; set; }
    }
}
