using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaWishWeapon
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 GachaWishWeaponGroupId { get; set; }
        [Key(2)] public System.Int64 WeaponId { get; set; }
        [Key(3)] public System.Int32 OrderNo { get; set; }
    }
}
