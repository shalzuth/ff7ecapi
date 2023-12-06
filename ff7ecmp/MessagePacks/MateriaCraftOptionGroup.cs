using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaCraftOptionGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 OptionPointThreshold { get; set; }
        [Key(2)] public System.Int64 MateriaOptionGroupId { get; set; }
    }
}
