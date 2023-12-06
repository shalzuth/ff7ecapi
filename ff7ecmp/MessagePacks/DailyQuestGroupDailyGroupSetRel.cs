using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DailyQuestGroupDailyGroupSetRel
    {
        [Key(0)] public System.Int64 DailyQuestGroupSetId { get; set; }
        [Key(1)] public System.Int64 DailyQuestGroupId { get; set; }
    }
}
