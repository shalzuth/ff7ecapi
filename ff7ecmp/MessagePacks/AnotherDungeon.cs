using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AnotherDungeon
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 AnotherAreaId { get; set; }
        [Key(2)] public System.Int32 DifficultyLevel { get; set; }
        [Key(3)] public System.Int64 AnotherDungeonDifficultySettingId { get; set; }
        [Key(4)] public System.Int32 OrderNo { get; set; }
        [Key(5)] public System.Int32 MaxBossEnhanceStage { get; set; }
        [Key(6)] public System.Int32 ConsumptionCount { get; set; }
        [Key(7)] public System.Int64 FirstRewardSetId { get; set; }
        [Key(8)] public System.Int64 ScoreOptionGroupId { get; set; }
        [Key(9)] public System.Int64 BuffDebuffGroupId { get; set; }
        [Key(10)] public System.Int64 DisplayConditionSetId { get; set; }
        [Key(11)] public System.Int64 LockConditionSetId { get; set; }
        [Key(12)] public System.Int64 DungeonMissionId0 { get; set; }
        [Key(13)] public System.Int64 DungeonMissionId1 { get; set; }
        [Key(14)] public System.Int64 DungeonMissionId2 { get; set; }
    }
}
