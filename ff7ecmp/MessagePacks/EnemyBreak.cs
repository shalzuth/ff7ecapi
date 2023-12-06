using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EnemyBreak
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Duration { get; set; }
        [Key(2)] public System.Int64 EnemyBreakAtbRecoveryGroupId { get; set; }
        [Key(3)] public System.Int64 ResistBuffDebuffId { get; set; }
        [Key(4)] public System.Int64 ResistStatusConditionId { get; set; }
        [Key(5)] public System.Int64 ResistElementId { get; set; }
        [Key(6)] public System.Int64 ResistDamageId { get; set; }
        [Key(7)] public System.Int64 EnemyBreakDurationExtensionGroupId { get; set; }
    }
}
