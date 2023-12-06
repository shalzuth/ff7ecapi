using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SoloAreaBattle
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 SoloAreaId { get; set; }
        [Key(2)] public System.Int64 PremiseSoloAreaBattleId { get; set; }
        [Key(3)] public System.Int32 OrderNo { get; set; }
        [Key(4)] public System.Int64 BattleId { get; set; }
        [Key(5)] public System.Int64 BattleRankGroupId { get; set; }
        [Key(6)] public System.Int32 AreaBattleDisplayType { get; set; }
        [Key(7)] public System.Int32 StaminaCost { get; set; }
        [Key(8)] public System.Int64 FirstRewardSetId { get; set; }
        [Key(9)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(10)] public System.Int64 LockConditionSetId { get; set; }
        [Key(11)] public System.Int64 NameLanguageId { get; set; }
        [Key(12)] public System.Int64 IngameResourceId { get; set; }
        [Key(13)] public System.Int64 OutgameResourceId { get; set; }
        [Key(14)] public System.Int32 ResetMaxWinCount { get; set; }
        [Key(15)] public System.Int64 WinResetId { get; set; }
    }
}
