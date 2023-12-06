using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class RewardWeapon
    {
        [Key(0)] public System.Int64 RewardId { get; set; }
        [Key(1)] public System.Int32 RarityType { get; set; }
    }
}
