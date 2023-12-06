using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class CampaignEnhance
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 EnhanceType { get; set; }
        [Key(2)] public System.Int32 Priority { get; set; }
        [Key(3)] public System.Int64 StartDatetime { get; set; }
        [Key(4)] public System.Int64 EndDatetime { get; set; }
        [Key(5)] public System.Int64 NameLanguageId { get; set; }
        [Key(6)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(7)] public System.Int64 AutoEffectCoefficient { get; set; }
    }
}
