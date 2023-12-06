using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DungeonDramaSelectionChoice
    {
        [Key(0)] public System.Int64 DungeonDramaSelectionId { get; set; }
        [Key(1)] public System.Int64 Idx { get; set; }
        [Key(2)] public System.Int64 RewardSetId { get; set; }
        [Key(3)] public System.Boolean IsOnlyOnceReward { get; set; }
        [Key(4)] public System.Int64 ChoiceLanguageId { get; set; }
    }
}
