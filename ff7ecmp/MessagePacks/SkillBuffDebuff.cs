using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillBuffDebuff
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 SkillBuffDebuffType { get; set; }
        [Key(2)] public System.Int32 TriggerEffectLevel { get; set; }
        [Key(3)] public System.Int32 TriggerEffectLevelMax { get; set; }
        [Key(4)] public System.Int32 MinDurationSec { get; set; }
        [Key(5)] public System.Int32 MaxDurationSec { get; set; }
        [Key(6)] public System.Int32 MinDuplicationDurationSec { get; set; }
        [Key(7)] public System.Int32 MaxDuplicationDurationSec { get; set; }
        [Key(8)] public System.Boolean IgnoreResist { get; set; }
    }
}
