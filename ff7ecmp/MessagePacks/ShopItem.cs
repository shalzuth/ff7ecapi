using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ShopItem
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ShopId { get; set; }
        [Key(2)] public System.Int32 ShopItemType { get; set; }
        [Key(3)] public System.Int32 MaxCount { get; set; }
        [Key(4)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(5)] public System.Int64 LockConditionSetId { get; set; }
        [Key(6)] public System.Int64 RewardSetId { get; set; }
        [Key(7)] public System.Int64 BonusRewardSetId { get; set; }
        [Key(8)] public System.Int64 ConsumptionSetId { get; set; }
        [Key(9)] public System.Int64 ShopItemRepeatGroupId { get; set; }
        [Key(10)] public System.Int64 ShopItemBonusId { get; set; }
        [Key(11)] public System.Int32 OrderNo { get; set; }
        [Key(12)] public System.Boolean CanMultiPurchase { get; set; }
        [Key(13)] public System.Int64 NameLanguageId { get; set; }
        [Key(14)] public System.Int64 SubNameLanguageId { get; set; }
        [Key(15)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(16)] public System.Int64 ResourceId { get; set; }
        [Key(17)] public System.Int64 ResetId { get; set; }
        [Key(18)] public System.Int64 PremiseShopItemId { get; set; }
        [Key(19)] public System.Int64 StoreProductGroupId { get; set; }
        [Key(20)] public System.Boolean IsSale { get; set; }
    }
}
