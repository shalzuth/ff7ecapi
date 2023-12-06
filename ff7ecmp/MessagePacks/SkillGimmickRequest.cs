using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillGimmickRequest
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 RequestSuccessCount { get; set; }
        [Key(2)] public System.Int64 SkillRequestSuccessSkillBaseId { get; set; }
        [Key(3)] public System.Int64 SkillRequestFinalSuccessSkillBaseId { get; set; }
        [Key(4)] public System.Int64 SkillRequestSkillGroupId { get; set; }
    }
}
