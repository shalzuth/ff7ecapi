using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class LoginBonusSheetReward
    {
        [Key(0)] public System.Int64 LoginBonusSheetId { get; set; }
        [Key(1)] public System.Int32 LoginCount { get; set; }
        [Key(2)] public System.Int64 RewardSetId { get; set; }
        [Key(3)] public System.Int64 ResourceId { get; set; }
    }
}
