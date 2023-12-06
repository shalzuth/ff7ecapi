using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class WeaponReleaseParameter
    {
        [Key(0)] public System.Int64 WeaponReleaseParameterGroupId { get; set; }
        [Key(1)] public System.Int32 ReleaseCount { get; set; }
        [Key(2)] public System.Int32 DamageCoefficient { get; set; }
    }
}
