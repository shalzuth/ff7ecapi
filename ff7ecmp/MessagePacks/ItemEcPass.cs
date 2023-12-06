using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ItemEcPass
    {
        [Key(0)] public System.Int64 ItemId { get; set; }
        [Key(1)] public System.Int32 EffectiveMin { get; set; }
        [Key(2)] public System.Int64 ShopItemId { get; set; }
        [Key(3)] public System.Int64 CampaignId { get; set; }
        [Key(4)] public System.Int64 DailyRewardGroupId { get; set; }
        [Key(5)] public System.Int32 EcPassType { get; set; }
    }
}
