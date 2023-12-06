using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaGroupRel
    {
        [Key(0)] public System.Int64 MateriaGroupId { get; set; }
        [Key(1)] public System.Int64 MateriaId { get; set; }
    }
}
