using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class LoginBonus
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 LoginBonusType { get; set; }
        [Key(2)] public System.Int32 ContinuousType { get; set; }
        [Key(3)] public System.Int32 DisplayPriority { get; set; }
        [Key(4)] public System.Int64 LoginBonusSheetGroupId { get; set; }
        [Key(5)] public System.Int64 NameLanguageId { get; set; }
        [Key(6)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(7)] public System.Int64 BackgroundResourceId { get; set; }
        [Key(8)] public System.Int64 LayoutResourceId { get; set; }
        [Key(9)] public System.Int64 TriggerConditionSetId { get; set; }
        [Key(10)] public System.Int64 StartDatetime { get; set; }
        [Key(11)] public System.Int64 TriggerEndDatetime { get; set; }
        [Key(12)] public System.Int64 ReceiveEndDatetime { get; set; }
    }
}
