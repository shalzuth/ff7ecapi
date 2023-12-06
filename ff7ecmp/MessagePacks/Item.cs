using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Item
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 ItemType { get; set; }
        [Key(2)] public System.Int32 ItemRarityType { get; set; }
        [Key(3)] public System.Int64 MaxCapacity { get; set; }
        [Key(4)] public System.Int64 ResourceId { get; set; }
        [Key(5)] public System.Int64 NameLanguageId { get; set; }
        [Key(6)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(7)] public System.Int32 ObtainCountMax { get; set; }
        [Key(8)] public System.Int64 ObtainResetId { get; set; }
        [Key(9)] public System.Int32 ConsumptionCountMax { get; set; }
        [Key(10)] public System.Int64 ConsumptionResetId { get; set; }
        [Key(11)] public System.Int64 StartDatetime { get; set; }
        [Key(12)] public System.Int64 EndDatetime { get; set; }
        [Key(13)] public System.Int64 OrderNo { get; set; }
    }
}
