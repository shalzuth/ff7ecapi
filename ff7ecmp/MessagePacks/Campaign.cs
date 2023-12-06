using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Campaign
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 CampaignType { get; set; }
        [Key(2)] public System.Int64 CampaignEffectGroupId { get; set; }
        [Key(3)] public System.Int64 TargetCampaignCharacterGroupId { get; set; }
        [Key(4)] public System.Int32 CharacterMaxLevel { get; set; }
        [Key(5)] public System.Int32 UserRankMax { get; set; }
        [Key(6)] public System.Int64 CampaignTargetTypeGroupId { get; set; }
        [Key(7)] public System.Int64 DisableCampaignTargetGroupId { get; set; }
        [Key(8)] public System.Int64 LockConditionSetId { get; set; }
        [Key(9)] public System.Int64 StartDatetime { get; set; }
        [Key(10)] public System.Int64 EndDatetime { get; set; }
        [Key(11)] public System.Int64 EcPassItemId { get; set; }
    }
}
