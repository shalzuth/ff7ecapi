using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleFieldEffectGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
    }
}
