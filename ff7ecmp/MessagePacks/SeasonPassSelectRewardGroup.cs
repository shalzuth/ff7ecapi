using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SeasonPassSelectRewardGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ExpiredSendGiftRewardSetId { get; set; }
        [Key(2)] public System.Int64 ResourceId { get; set; }
    }
}
