using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaStampSheet
    {
        [Key(0)] public System.Int64 Id { get; set; }
    }
}
