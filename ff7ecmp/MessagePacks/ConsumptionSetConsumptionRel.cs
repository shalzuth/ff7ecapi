using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ConsumptionSetConsumptionRel
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ConsumptionSetId { get; set; }
        [Key(2)] public System.Int64 RewardId { get; set; }
        [Key(3)] public System.Int32 ConsumptionCount { get; set; }
    }
}
