using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class TowerFloor
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 TowerId { get; set; }
        [Key(2)] public System.Int32 FloorSeq { get; set; }
        [Key(3)] public System.Int64 TowerFloorGroupId { get; set; }
        [Key(4)] public System.Int32 TowerFloorDisplayType { get; set; }
        [Key(5)] public System.Int64 BattleId { get; set; }
        [Key(6)] public System.Int64 FirstRewardSetId { get; set; }
        [Key(7)] public System.Int64 FloorRewardSetId { get; set; }
        [Key(8)] public System.Int64 LockConditionSetId { get; set; }
        [Key(9)] public System.Int64 NameLanguageId { get; set; }
        [Key(10)] public System.Int64 ResourceId { get; set; }
    }
}
