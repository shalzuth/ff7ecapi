using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MissionProgress
    {
        [Key(0)] public System.Int64 MissionId { get; set; }
        [Key(1)] public System.Int64 ProgressCount { get; set; }
        [Key(2)] public System.Int64 RewardSetId { get; set; }
        [Key(3)] public System.Int64 BonusPoint { get; set; }
        [Key(4)] public System.Boolean IsExpand { get; set; }
    }
}
