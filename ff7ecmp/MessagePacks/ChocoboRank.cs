using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ChocoboRank
    {
        [Key(0)] public System.Int64 ChocoboRankGroupId { get; set; }
        [Key(1)] public System.Int32 RankType { get; set; }
        [Key(2)] public System.Int32 InitialValue { get; set; }
        [Key(3)] public System.Int32 LimitValue { get; set; }
        [Key(4)] public System.Int32 RankUpValue { get; set; }
    }
}
