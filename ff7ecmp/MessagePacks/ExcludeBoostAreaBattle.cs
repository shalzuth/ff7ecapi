using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ExcludeBoostAreaBattle
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 BoostAreaTargetType { get; set; }
        [Key(2)] public System.Int64 TargetId { get; set; }
    }
}
