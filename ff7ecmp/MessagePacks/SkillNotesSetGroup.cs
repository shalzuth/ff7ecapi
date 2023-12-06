using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillNotesSetGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Seq { get; set; }
        [Key(2)] public System.Int64 SkillNotesSetId { get; set; }
        [Key(3)] public System.Int32 NotesCombinationType { get; set; }
        [Key(4)] public System.Int32 Count { get; set; }
        [Key(5)] public System.Int32 SkillNotesDisplayType { get; set; }
    }
}
