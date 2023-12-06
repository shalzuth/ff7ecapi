using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class CampaignCharacterGroupRel
    {
        [Key(0)] public System.Int64 CampaignCharacterGroupId { get; set; }
        [Key(1)] public System.Int64 CharacterId { get; set; }
        [Key(2)] public System.Int32 MaxLevel { get; set; }
    }
}
