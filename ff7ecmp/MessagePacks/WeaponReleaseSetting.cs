using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class WeaponReleaseSetting
    {
        [Key(0)] public System.Int64 WeaponReleaseSettingGroupId { get; set; }
        [Key(1)] public System.Int32 ReleaseCount { get; set; }
        [Key(2)] public System.Int32 LevelLimit { get; set; }
        [Key(3)] public System.Int64 WeaponIngredientGroupId { get; set; }
        [Key(4)] public System.Int32 ConsumptionGil { get; set; }
    }
}
