using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DungeonBattleRel
    {
        [Key(0)] public System.Int64 DungeonId { get; set; }
        [Key(1)] public System.Int64 BattleId { get; set; }
    }
}
