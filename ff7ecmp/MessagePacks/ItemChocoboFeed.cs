using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ItemChocoboFeed
    {
        [Key(0)] public System.Int64 ItemId { get; set; }
        [Key(1)] public System.Int32 LowerLimitChocoboRankType { get; set; }
        [Key(2)] public System.Int32 UpperLimitChocoboRankType { get; set; }
        [Key(3)] public System.Int32 FoodCountValue { get; set; }
        [Key(4)] public System.Int32 Speed { get; set; }
        [Key(5)] public System.Int32 Stamina { get; set; }
        [Key(6)] public System.Int32 Intelligence { get; set; }
        [Key(7)] public System.Int32 Adaptability { get; set; }
        [Key(8)] public System.Int32 LotCount { get; set; }
        [Key(9)] public System.Int64 ChocoboAdditionalTypeLotGroupId { get; set; }
        [Key(10)] public System.Int64 ChocoboAdditionalValueLotGroupId { get; set; }
        [Key(11)] public System.Int32 Priority { get; set; }
    }
}
