using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class CharacterStoryEpisode
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 CharacterStorySectionId { get; set; }
        [Key(2)] public System.Int64 PremiseCharacterStoryEpisodeId { get; set; }
        [Key(3)] public System.Int64 NameLanguageId { get; set; }
        [Key(4)] public System.Int32 CharacterStoryEpisodeType { get; set; }
        [Key(5)] public System.Int64 BattleId { get; set; }
        [Key(6)] public System.Int64 DungeonId { get; set; }
        [Key(7)] public System.Int64 FirstClearRewardSetId { get; set; }
        [Key(8)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(9)] public System.Int64 LockConditionSetId { get; set; }
        [Key(10)] public System.Int32 PartyCharacterCount { get; set; }
        [Key(11)] public System.Int64 PartyCharacterGroupId { get; set; }
        [Key(12)] public System.Boolean IsDrama { get; set; }
        [Key(13)] public System.Boolean IsBattle { get; set; }
        [Key(14)] public System.Int32 OrderNo { get; set; }
        [Key(15)] public System.Int64 SubNameLanguageId { get; set; }
    }
}
