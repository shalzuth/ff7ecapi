using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillGimmickNotesCountDetail
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Idx { get; set; }
        [Key(2)] public System.Int32 NotesCount { get; set; }
        [Key(3)] public System.Int32 EffectCount { get; set; }
        [Key(4)] public System.Int64 SkillBaseId { get; set; }
        [Key(5)] public System.Int32 DurationSec { get; set; }
    }
}
