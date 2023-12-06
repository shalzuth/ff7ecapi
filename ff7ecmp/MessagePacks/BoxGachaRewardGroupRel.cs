using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BoxGachaRewardGroupRel
    {
        [Key(0)] public System.Int64 BoxGachaId { get; set; }
        [Key(1)] public System.Int64 BoxGachaRewardGroupId { get; set; }
        [Key(2)] public System.Int64 Seq { get; set; }
        [Key(3)] public System.Int64 NextSeq { get; set; }
    }
}
