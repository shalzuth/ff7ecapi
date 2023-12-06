using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillGimmickHealing
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 HealCoefficient { get; set; }
        [Key(2)] public System.Int32 FixedValue { get; set; }
        [Key(3)] public System.Int32 HealDurationSec { get; set; }
    }
}
