using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaStep
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 Seq { get; set; }
        [Key(2)] public System.Int64 NextSeq { get; set; }
        [Key(3)] public System.Int64 GachaStepGroupId { get; set; }
        [Key(4)] public System.Int32 GachaConsumptionType { get; set; }
        [Key(5)] public System.Int32 ConsumptionCount { get; set; }
        [Key(6)] public System.Int32 DrawCount { get; set; }
        [Key(7)] public System.Int32 GachaFixedLotType { get; set; }
        [Key(8)] public System.Int64 BonusRewardSetId { get; set; }
        [Key(9)] public System.Int64 BonusLanguageId { get; set; }
        [Key(10)] public System.Int32 DisplayType { get; set; }
        [Key(11)] public System.Int32 GachaStepNotiType { get; set; }
        [Key(12)] public System.Int32 GachaNotiValue { get; set; }
        [Key(13)] public System.Int32 GachaDetailDisplayType { get; set; }
        [Key(14)] public System.Int64 DescriptionLanguageId { get; set; }
    }
}
