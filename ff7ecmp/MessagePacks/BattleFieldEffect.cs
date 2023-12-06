using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleFieldEffect
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 BattleFieldEffectType { get; set; }
        [Key(2)] public System.Int32 BattleFieldEffectTargetType { get; set; }
        [Key(3)] public System.Boolean IsPermil { get; set; }
        [Key(4)] public System.Int32 Value { get; set; }
        [Key(5)] public System.Int32 EffectDurationSec { get; set; }
    }
}
