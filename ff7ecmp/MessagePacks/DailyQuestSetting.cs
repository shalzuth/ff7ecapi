using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DailyQuestSetting
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 StartDatetime { get; set; }
        [Key(2)] public System.Int64 ConditionSetId { get; set; }
    }
}
