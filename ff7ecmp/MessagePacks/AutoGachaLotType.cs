using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AutoGachaLotType
    {
        [Key(0)] public System.Int64 GachaId { get; set; }
        [Key(1)] public System.Int32 GachaLotType { get; set; }
    }
}
