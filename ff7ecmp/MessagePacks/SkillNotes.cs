using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillNotes
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 SkillNotesType { get; set; }
        [Key(2)] public System.Int32 Count { get; set; }
    }
}
