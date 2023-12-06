using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaLevel
    {
        [Key(0)] public System.Int64 MateriaLevelGroupId { get; set; }
        [Key(1)] public System.Int64 Level { get; set; }
        [Key(2)] public System.Int32 ExpCoefficient { get; set; }
        [Key(3)] public System.Int32 IngredientExpCoefficient { get; set; }
        [Key(4)] public System.Int32 SaleGilCoefficient { get; set; }
    }
}
