using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DungeonBuffDebuffResistDebuff
    {
        [Key(0)] public System.Int64 DungeonBuffDebuffId { get; set; }
        [Key(1)] public System.Int32 BuffDebuffType { get; set; }
    }
}
