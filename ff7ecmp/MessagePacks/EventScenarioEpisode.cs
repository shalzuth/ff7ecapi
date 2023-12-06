using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EventScenarioEpisode
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 EventScenarioSectionId { get; set; }
        [Key(2)] public System.Int64 PremiseEventScenarioEpisodeId { get; set; }
        [Key(3)] public System.Int64 DungeonId { get; set; }
        [Key(4)] public System.Int32 OrderNo { get; set; }
        [Key(5)] public System.Int64 FirstRewardSetId { get; set; }
        [Key(6)] public System.Int32 FirstRewardCount { get; set; }
        [Key(7)] public System.Int64 NameLanguageId { get; set; }
        [Key(8)] public System.Boolean IsDungeon { get; set; }
        [Key(9)] public System.Int32 ScriptVersion { get; set; }
        [Key(10)] public System.Int32 StoryEpisodeType { get; set; }
        [Key(11)] public System.Int64 EventSoloBattleId { get; set; }
    }
}
