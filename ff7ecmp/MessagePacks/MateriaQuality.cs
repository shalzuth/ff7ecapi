using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaQuality
    {
        [Key(0)] public System.Int64 MateriaQualityGroupId { get; set; }
        [Key(1)] public System.Int32 QualityType { get; set; }
        [Key(2)] public System.Int32 SkillCoefficient { get; set; }
    }
}
