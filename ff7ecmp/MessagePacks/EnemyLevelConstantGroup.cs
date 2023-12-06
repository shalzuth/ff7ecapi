using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EnemyLevelConstantGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
    }
}
