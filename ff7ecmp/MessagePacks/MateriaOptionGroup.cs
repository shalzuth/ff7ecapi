using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaOptionGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 MateriaParameterCountGroupId { get; set; }
        [Key(2)] public System.Int64 MateriaQualityLotGroupId { get; set; }
    }
}
