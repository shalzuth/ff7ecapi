using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class StoryEpisode
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 StorySectionId { get; set; }
        [Key(2)] public System.Int32 StoryEpisodeType { get; set; }
        [Key(3)] public System.Int64 PremiseStoryEpisodeId { get; set; }
        [Key(4)] public System.Int64 DungeonId { get; set; }
        [Key(5)] public System.Int32 OrderNo { get; set; }
        [Key(6)] public System.Int64 FirstRewardSetId { get; set; }
        [Key(7)] public System.Int32 FirstRewardCount { get; set; }
        [Key(8)] public System.Int64 DisplayEnemyGroupId { get; set; }
        [Key(9)] public System.Int32 StoryPartyCombatValue { get; set; }
        [Key(10)] public System.Int32 FreePartyCombatValue { get; set; }
        [Key(11)] public System.Int32 ScriptVersion { get; set; }
        [Key(12)] public System.Int64 StoryPartyFirstRewardSetId { get; set; }
        [Key(13)] public System.Int64 StoryPartyCharacterGroupId { get; set; }
        [Key(14)] public System.Int32 StoryPartyCharacterCount { get; set; }
        [Key(15)] public System.Int64 StoryBattleId { get; set; }
        [Key(16)] public System.Int64 ControlCharacterNovelSetId { get; set; }
        [Key(17)] public System.Int64 NameLanguageId { get; set; }
        [Key(18)] public System.Int64 SubNameLanguageId { get; set; }
        [Key(19)] public System.Boolean IsEpisode { get; set; }
        [Key(20)] public System.Boolean IsBattle { get; set; }
        [Key(21)] public System.Boolean IsDungeon { get; set; }
        [Key(22)] public System.Boolean IsInitialDownload { get; set; }
        [Key(23)] public System.Int64 TitleSynopsisLanguageId { get; set; }
        [Key(24)] public System.Int64 ResourceId { get; set; }
    }
}
