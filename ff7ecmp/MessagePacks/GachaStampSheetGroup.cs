using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaStampSheetGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 MaxSheetCount { get; set; }
        [Key(2)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(3)] public System.Int64 GachaStampLotGroupId { get; set; }
        [Key(4)] public System.Int64 TitleLanguageId { get; set; }
        [Key(5)] public System.Int64 DescriptionTemplateLanguageId { get; set; }
        [Key(6)] public System.Int64 LotRatioLanguageId { get; set; }
        [Key(7)] public System.Int64 StampLanguageId { get; set; }
        [Key(8)] public System.Int64 ComplementLanguageId { get; set; }
        [Key(9)] public System.Int64 PickupLanguageId { get; set; }
        [Key(10)] public System.Int64 ResourceId { get; set; }
    }
}
