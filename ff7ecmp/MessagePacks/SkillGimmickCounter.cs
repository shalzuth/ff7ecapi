using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillGimmickCounter
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 SkillGimmickCounterType { get; set; }
        [Key(2)] public System.Boolean EnableActionSkill { get; set; }
    }
}
