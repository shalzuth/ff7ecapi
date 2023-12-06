using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaWishWeaponGroupRel
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 GachaWishId { get; set; }
        [Key(2)] public System.Int64 GachaWishWeaponGroupId { get; set; }
        [Key(3)] public System.Int64 StartDatetime { get; set; }
    }
}
