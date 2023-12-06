using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Materia
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 MateriaBaseCoefficientGroupId { get; set; }
        [Key(2)] public System.Int64 MateriaQualityGroupId { get; set; }
        [Key(3)] public System.Int64 MateriaLevelGroupId { get; set; }
        [Key(4)] public System.Int64 MateriaEnhanceGroupId { get; set; }
        [Key(5)] public System.Int64 MateriaEvolveSettingGroupId { get; set; }
    }
}
