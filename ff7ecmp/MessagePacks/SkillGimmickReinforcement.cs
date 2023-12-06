using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillGimmickReinforcement
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 SkillGimmickReinforcementGroupId { get; set; }
        [Key(2)] public System.Int32 DurationSec { get; set; }
        [Key(3)] public System.Int32 IntervalSec { get; set; }
        [Key(4)] public System.Int32 MaxReinforcementCount { get; set; }
    }
}
