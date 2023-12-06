using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class UserRank
    {
        [Key(0)] public System.Int64 Rank { get; set; }
        [Key(1)] public System.Int64 StaminaCountMax { get; set; }
        [Key(2)] public System.Int64 RequiredExp { get; set; }
    }
}
