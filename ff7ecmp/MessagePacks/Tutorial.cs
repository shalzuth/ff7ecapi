using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Tutorial
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 TutorialStepType { get; set; }
        [Key(2)] public System.Int64 Step { get; set; }
        [Key(3)] public System.Int64 ConditionSetId { get; set; }
        [Key(4)] public System.Int64 RewardSetId { get; set; }
    }
}
