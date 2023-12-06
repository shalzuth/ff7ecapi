using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ShopLineupReset
    {
        [Key(0)] public System.Int64 ShopId { get; set; }
        [Key(1)] public System.Int32 LineupResetCount { get; set; }
        [Key(2)] public System.Int32 ConsumptionCount { get; set; }
    }
}
