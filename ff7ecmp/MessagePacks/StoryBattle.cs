using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class StoryBattle
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 StoryPartyBattleId { get; set; }
        [Key(2)] public System.Int64 FreePartyBattleId { get; set; }
    }
}
