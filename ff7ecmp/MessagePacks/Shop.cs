using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Shop
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ShopGroupId { get; set; }
        [Key(2)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(3)] public System.Int64 LockConditionSetId { get; set; }
        [Key(4)] public System.Int32 OrderNo { get; set; }
        [Key(5)] public System.Int32 ShopDisplayType { get; set; }
        [Key(6)] public System.Int32 DisplayCurrencyType { get; set; }
        [Key(7)] public System.Int64 DisplayCurrencyItemId { get; set; }
        [Key(8)] public System.Int64 ShopLineupId { get; set; }
        [Key(9)] public System.Boolean CanLineupReset { get; set; }
        [Key(10)] public System.Int32 MaxLineupResetCount { get; set; }
        [Key(11)] public System.Int64 NameLanguageId { get; set; }
        [Key(12)] public System.Int64 ResourceId { get; set; }
        [Key(13)] public System.Int64 LineupResetId { get; set; }
        [Key(14)] public System.Int64 MaxLineupResetId { get; set; }
        [Key(15)] public System.Boolean CanFilter { get; set; }
        [Key(16)] public System.Boolean HasBanner { get; set; }
        [Key(17)] public System.Int64 PickupCharacterCostumeId0 { get; set; }
        [Key(18)] public System.Int64 PickupCharacterCostumeId1 { get; set; }
        [Key(19)] public System.Int64 PickupCharacterCostumeId2 { get; set; }
        [Key(20)] public System.Int32 ShopEmptyBehaviorType { get; set; }
    }
}
