using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DungeonBuffDebuffGroupRel
    {
        [Key(0)] public System.Int64 DungeonBuffDebuffGroupId { get; set; }
        [Key(1)] public System.Int64 DungeonBuffDebuffId { get; set; }
        [Key(2)] public System.Int32 Value { get; set; }
    }
}
