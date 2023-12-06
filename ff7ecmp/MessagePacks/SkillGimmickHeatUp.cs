using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillGimmickHeatUp
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 RemainNotesSetCount { get; set; }
        [Key(2)] public System.Int64 DamageCoefficient { get; set; }
        [Key(3)] public System.Int64 NameLanguageId { get; set; }
    }
}
