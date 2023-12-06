using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DailyQuestDailyQuestGroupRel
    {
        [Key(0)] public System.Int64 DailyQuestGroupId { get; set; }
        [Key(1)] public System.Int64 DailyQuestId { get; set; }
        [Key(2)] public System.Int32 WinCount { get; set; }
    }
}
