using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GiftMessage
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 RewardObtainType { get; set; }
        [Key(2)] public System.Int64 MessageLanguageId { get; set; }
    }
}
