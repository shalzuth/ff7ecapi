using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DailyQuestGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 Priority { get; set; }
        [Key(2)] public System.Int64 LockConditionSetId { get; set; }
        [Key(3)] public System.Int64 SubDailyQuestId { get; set; }
    }
}
