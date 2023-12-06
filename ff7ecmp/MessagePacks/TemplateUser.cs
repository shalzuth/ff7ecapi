using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class TemplateUser
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 CopyUserId { get; set; }
        [Key(2)] public System.Int64 UserRank { get; set; }
        [Key(3)] public System.Int64 GrantRewardSetId { get; set; }
        [Key(4)] public System.Boolean AllClearEpisode { get; set; }
        [Key(5)] public System.Boolean AllClearSoloAreaBattle { get; set; }
        [Key(6)] public System.Boolean AllClearMultiAreaBattle { get; set; }
        [Key(7)] public System.Boolean AllClearAnotherDungeon { get; set; }
        [Key(8)] public System.Boolean AllClearTutorialStep { get; set; }
        [Key(9)] public System.String DisplayName { get; set; }
    }
}
