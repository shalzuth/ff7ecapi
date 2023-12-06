using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EnemyBreakAtbRecoveryGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
    }
}
