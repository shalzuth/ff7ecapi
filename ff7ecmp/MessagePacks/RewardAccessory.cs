using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class RewardAccessory
    {
        [Key(0)] public System.Int64 RewardId { get; set; }
        [Key(1)] public System.Int32 QualityType { get; set; }
        [Key(2)] public System.Int32 PassiveSkillPoint { get; set; }
    }
}
