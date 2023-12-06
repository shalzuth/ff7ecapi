using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Advertisement
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 MaxViewCount { get; set; }
        [Key(2)] public System.Int64 ViewCountResetId { get; set; }
        [Key(3)] public System.Int64 RewardSetId { get; set; }
    }
}
