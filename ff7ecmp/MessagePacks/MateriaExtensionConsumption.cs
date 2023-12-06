using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaExtensionConsumption
    {
        [Key(0)] public System.Int32 Threshold { get; set; }
        [Key(1)] public System.Int32 ConsumptionStone { get; set; }
    }
}
