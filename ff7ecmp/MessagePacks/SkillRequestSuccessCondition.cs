using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillRequestSuccessCondition
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 SkillRequestSuccessConditionType { get; set; }
        [Key(2)] public System.Int32 SkillRequestSuccessConditionDetailType { get; set; }
    }
}
