using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillTriggerConditionTactics
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 TacticsType { get; set; }
        [Key(2)] public System.Int32 MinLevel { get; set; }
        [Key(3)] public System.Int32 MaxLevel { get; set; }
    }
}
