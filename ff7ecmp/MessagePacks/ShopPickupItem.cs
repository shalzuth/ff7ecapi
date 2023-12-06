using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ShopPickupItem
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ShopItemId { get; set; }
        [Key(2)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(3)] public System.Int32 OrderNo { get; set; }
        [Key(4)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(5)] public System.Int64 ResourceId { get; set; }
    }
}
