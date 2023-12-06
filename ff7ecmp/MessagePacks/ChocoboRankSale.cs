using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ChocoboRankSale
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ChocoboRankSaleGroupId { get; set; }
        [Key(2)] public System.Int32 RankType { get; set; }
        [Key(3)] public System.Int32 MedalCount { get; set; }
    }
}
