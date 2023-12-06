using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillRequestSkillGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 SkillRequestSuccessConditionGroupId { get; set; }
        [Key(2)] public System.Int32 Weight { get; set; }
        [Key(3)] public System.Int32 RequestCount { get; set; }
        [Key(4)] public System.Int64 SkillRequestSuccessLanguageGroupId { get; set; }
    }
}
