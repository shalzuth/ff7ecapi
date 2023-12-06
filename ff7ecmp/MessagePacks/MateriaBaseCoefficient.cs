using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaBaseCoefficient
    {
        [Key(0)] public System.Int64 MateriaBaseCoefficientGroupId { get; set; }
        [Key(1)] public System.Int64 EvolveCount { get; set; }
        [Key(2)] public System.Int32 QualityType { get; set; }
        [Key(3)] public System.Int32 BaseExp { get; set; }
        [Key(4)] public System.Int32 BaseIngredientExp { get; set; }
        [Key(5)] public System.Int32 BaseSaleGil { get; set; }
        [Key(6)] public System.Int32 ConsumptionGilCoefficient { get; set; }
    }
}
