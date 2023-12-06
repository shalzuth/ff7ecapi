using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaEnhance
    {
        [Key(0)] public System.Int64 MateriaEnhanceGroupId { get; set; }
        [Key(1)] public System.Int64 Level { get; set; }
        [Key(2)] public System.Boolean EnhanceParameter { get; set; }
    }
}
