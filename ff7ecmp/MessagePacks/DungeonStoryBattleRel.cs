using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DungeonStoryBattleRel
    {
        [Key(0)] public System.Int64 DungeonId { get; set; }
        [Key(1)] public System.Int64 StoryBattleId { get; set; }
        [Key(2)] public System.Int32 OrderNo { get; set; }
    }
}
