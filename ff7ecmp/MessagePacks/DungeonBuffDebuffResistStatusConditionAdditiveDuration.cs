using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DungeonBuffDebuffResistStatusConditionAdditiveDuration
    {
        [Key(0)] public System.Int64 DungeonBuffDebuffId { get; set; }
        [Key(1)] public System.Int32 StatusConditionType { get; set; }
    }
}
