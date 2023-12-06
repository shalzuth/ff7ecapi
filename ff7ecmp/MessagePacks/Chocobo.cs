using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Chocobo
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 ChocoboType { get; set; }
        [Key(2)] public System.Int32 SexType { get; set; }
        [Key(3)] public System.Int32 ChocoboRarityType { get; set; }
        [Key(4)] public System.Int64 ChocoboAreaTypeGroupId { get; set; }
        [Key(5)] public System.Int64 ChocoboRankPotentialId { get; set; }
        [Key(6)] public System.Int64 ChocoboParameterRatioId { get; set; }
        [Key(7)] public System.Int64 ChocoboRankGroupId { get; set; }
        [Key(8)] public System.Int64 ChocoboExpeditionParameterGroupId { get; set; }
        [Key(9)] public System.Int64 ChocoboRankSaleGroupId { get; set; }
        [Key(10)] public System.Int64 ChocoboParameterDifferenceGroupId { get; set; }
        [Key(11)] public System.Int32 LimitRankParameterCoefficientBp { get; set; }
        [Key(12)] public System.Int64 DefaultNameLanguageId { get; set; }
    }
}
