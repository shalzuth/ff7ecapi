using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EnemyBreakAtbRecovery
    {
        [Key(0)] public System.Int64 EnemyBreakAtbRecoveryGroupId { get; set; }
        [Key(1)] public System.Int64 RemainingPhaseTime { get; set; }
        [Key(2)] public System.Int64 RecoveryCost { get; set; }
    }
}
