using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AutoGachaStampProbability
    {
        [Key(0)] public System.Int64 GachaStampLotGroupId { get; set; }
        [Key(1)] public System.Int32 ProgressCount { get; set; }
        [Key(2)] public System.Int64 ProbabilityPpb { get; set; }
        [Key(3)] public System.String DisplayProbabilityStr { get; set; }
    }
}
