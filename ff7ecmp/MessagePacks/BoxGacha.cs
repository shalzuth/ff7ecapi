using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BoxGacha
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 BoxGachaGroupId { get; set; }
        [Key(2)] public System.Int64 NameLanguageId { get; set; }
        [Key(3)] public System.Int64 ConsumptionItemId { get; set; }
        [Key(4)] public System.Int64 ConsumptionItemCount { get; set; }
        [Key(5)] public System.Int64 ResourceId { get; set; }
        [Key(6)] public System.Int32 OrderNo { get; set; }
    }
}
