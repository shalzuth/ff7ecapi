using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class GachaWeaponDirection
    {
        [Key(0)] public System.Int64 WeaponId { get; set; }
        [Key(1)] public System.Boolean HasSkillDirection { get; set; }
    }
}
