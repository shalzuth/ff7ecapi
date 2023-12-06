using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ChocoboExpedition
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ChocoboExpeditionGroupId { get; set; }
        [Key(2)] public System.Int32 OrderNo { get; set; }
        [Key(3)] public System.Int32 AreaType { get; set; }
        [Key(4)] public System.Int64 ExpeditionRewardId { get; set; }
        [Key(5)] public System.Int32 BaseChocoboMedalCount { get; set; }
        [Key(6)] public System.Int32 BaseGil { get; set; }
        [Key(7)] public System.Int32 BaseExp { get; set; }
        [Key(8)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(9)] public System.Int64 LockConditionSetId { get; set; }
        [Key(10)] public System.Int64 NameLanguageId { get; set; }
        [Key(11)] public System.Int64 DescriptionLanguageId { get; set; }
    }
}
