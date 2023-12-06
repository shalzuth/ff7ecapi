using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillNotesSetGroupSeries
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Seq { get; set; }
        [Key(2)] public System.Int64 SkillNotesSetGroupId { get; set; }
    }
}
