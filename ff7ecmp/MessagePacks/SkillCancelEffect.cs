using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillCancelEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 SkillCancelType { get; set; }
        [Key(2)] public System.Int64 BuffDebuffGroupId { get; set; }
        [Key(3)] public System.Int64 StatusConditionGroupId { get; set; }
    }
}
