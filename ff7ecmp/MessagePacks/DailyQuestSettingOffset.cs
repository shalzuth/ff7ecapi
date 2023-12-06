using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DailyQuestSettingOffset
    {
        [Key(0)] public System.Int64 DailyQuestSettingId { get; set; }
        [Key(1)] public System.Int32 OffsetDay { get; set; }
        [Key(2)] public System.Int64 DailyQuestGroupSetId { get; set; }
    }
}
