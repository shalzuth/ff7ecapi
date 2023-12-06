using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class CampaignTargetTypeRel
    {
        [Key(0)] public System.Int64 CampaignTargetTypeGroupId { get; set; }
        [Key(1)] public System.Int32 CampaignTargetType { get; set; }
    }
}
