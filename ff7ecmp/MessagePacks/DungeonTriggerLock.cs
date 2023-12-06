using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DungeonTriggerLock
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 DungeonId { get; set; }
        [Key(2)] public System.Int64 ConsumptionSetId { get; set; }
        [Key(3)] public System.Int64 LockMessageLanguageId { get; set; }
    }
}
