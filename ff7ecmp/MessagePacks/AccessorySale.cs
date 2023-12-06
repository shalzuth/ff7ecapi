using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AccessorySale
    {
        [Key(0)] public System.Int64 AccessorySaleGroupId { get; set; }
        [Key(1)] public System.Int32 QualityType { get; set; }
        [Key(2)] public System.Int32 SaleGilCoefficient { get; set; }
    }
}
