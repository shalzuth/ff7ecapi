using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AccessoryPassivePointLot
    {
        [Key(0)] public System.Int64 AccessoryPassivePointGroupId { get; set; }
        [Key(1)] public System.Int32 AddPassivePoint { get; set; }
    }
}
