using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SeasonPassStep
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 SeasonPassStepGroupId { get; set; }
        [Key(2)] public System.Int32 SeasonPassRewardType { get; set; }
        [Key(3)] public System.Int64 Idx { get; set; }
        [Key(4)] public System.Int64 Level { get; set; }
        [Key(5)] public System.Boolean IsPickup { get; set; }
        [Key(6)] public System.Int32 SeasonPassRewardChooseType { get; set; }
        [Key(7)] public System.Int64 SeasonPassSelectRewardGroupId { get; set; }
        [Key(8)] public System.Int64 RewardSetId { get; set; }
    }
}
