using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaSupportEffectDetail
    {
        [Key(0)] public System.Int64 MateriaSupportEffectId { get; set; }
        [Key(1)] public System.Boolean IsPercent { get; set; }
        [Key(2)] public System.Int32 Value { get; set; }
    }
}
