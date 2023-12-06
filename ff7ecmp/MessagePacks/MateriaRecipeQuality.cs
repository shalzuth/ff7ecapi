using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaRecipeQuality
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 MateriaRecipeId { get; set; }
        [Key(2)] public System.Int32 QualityType { get; set; }
        [Key(3)] public System.Int64 MateriaDurationGroupId { get; set; }
    }
}
