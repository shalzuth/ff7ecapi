using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class RecoveryStoneConsumption
    {
        [Key(0)] public System.Int64 RecoveryStoneConsumptionGroupId { get; set; }
        [Key(1)] public System.Int32 StartRecoveryCount { get; set; }
        [Key(2)] public System.Int32 ConsumptionCount { get; set; }
        [Key(3)] public System.Int32 EffectValue { get; set; }
    }
}
