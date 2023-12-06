using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillRequestSuccessConditionRel
    {
        [Key(0)] public System.Int64 SkillRequestSuccessConditionGroupId { get; set; }
        [Key(1)] public System.Int64 SkillRequestSuccessConditionId { get; set; }
    }
}
