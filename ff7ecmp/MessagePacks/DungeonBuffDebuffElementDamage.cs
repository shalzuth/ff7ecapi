using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DungeonBuffDebuffElementDamage
    {
        [Key(0)] public System.Int64 DungeonBuffDebuffId { get; set; }
        [Key(1)] public System.Int32 ElementType { get; set; }
    }
}
