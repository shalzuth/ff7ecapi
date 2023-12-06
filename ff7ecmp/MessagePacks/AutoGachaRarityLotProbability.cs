using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AutoGachaRarityLotProbability
    {
        [Key(0)] public System.Int64 GachaRarityLotGroupId { get; set; }
        [Key(1)] public System.Int32 GachaLotType { get; set; }
        [Key(2)] public System.Int32 RarityType { get; set; }
        [Key(3)] public System.Int64 ProbabilityPpb { get; set; }
        [Key(4)] public System.String DisplayProbabilityStr { get; set; }
    }
}
