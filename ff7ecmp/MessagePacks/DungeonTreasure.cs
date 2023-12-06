using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DungeonTreasure
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 DungeonId { get; set; }
        [Key(2)] public System.Int64 RewardSetId { get; set; }
        [Key(3)] public System.Int64 DungeonTriggerLockId { get; set; }
        [Key(4)] public System.Int32 DungeonTreasureType { get; set; }
        [Key(5)] public System.Boolean IsOnlyOnce { get; set; }
        [Key(6)] public System.Int64 ResourceId { get; set; }
    }
}
