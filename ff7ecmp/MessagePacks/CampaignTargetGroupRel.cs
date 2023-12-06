using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class CampaignTargetGroupRel
    {
        [Key(0)] public System.Int64 CampaignTargetGroupId { get; set; }
        [Key(1)] public System.Int32 CampaignTargetType { get; set; }
        [Key(2)] public System.Int64 TargetId { get; set; }
    }
}
