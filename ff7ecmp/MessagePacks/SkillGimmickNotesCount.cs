using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillGimmickNotesCount
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 SkillGimmickNotesCountDetailId { get; set; }
        [Key(2)] public System.Int64 NameLanguageId { get; set; }
    }
}
