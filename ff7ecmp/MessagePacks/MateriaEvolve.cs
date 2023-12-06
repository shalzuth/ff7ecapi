using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaEvolve
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 MateriaId { get; set; }
        [Key(2)] public System.Int64 EvolveCount { get; set; }
        [Key(3)] public System.Int64 ActiveSkillId { get; set; }
    }
}
