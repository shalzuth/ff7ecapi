using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class CampaignEffect
    {
        [Key(0)] public System.Int64 CampaignEffectGroupId { get; set; }
        [Key(1)] public System.Int32 CampaignEffectType { get; set; }
        [Key(2)] public System.Int64 EffectValue { get; set; }
        [Key(3)] public System.Int64 TargetId { get; set; }
        [Key(4)] public System.Int64 NameLanguageId { get; set; }
        [Key(5)] public System.Int64 DescriptionLanguageId { get; set; }
    }
}
