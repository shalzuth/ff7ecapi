using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ShopItemRepeat
    {
        [Key(0)] public System.Int64 ShopItemRepeatGroupId { get; set; }
        [Key(1)] public System.Int32 PurchaseCount { get; set; }
        [Key(2)] public System.Int64 ConsumptionSetId { get; set; }
    }
}
