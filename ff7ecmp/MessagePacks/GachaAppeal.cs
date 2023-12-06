using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaAppeal
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 WeaponId { get; set; }
        [Key(2)] public System.Int32 RarityType { get; set; }
        [Key(3)] public System.Int64 ResourceId { get; set; }
    }
}
