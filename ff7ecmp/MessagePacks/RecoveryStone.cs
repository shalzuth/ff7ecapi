using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class RecoveryStone
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 RecoveryType { get; set; }
        [Key(2)] public System.Int64 RecoveryStoneConsumptionGroupId { get; set; }
        [Key(3)] public System.Int64 RecoveryResetId { get; set; }
        [Key(4)] public System.Int64 ConditionSetId { get; set; }
    }
}
