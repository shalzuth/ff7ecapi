using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class EventDetailEnemy
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 EventDetailId { get; set; }
        [Key(2)] public System.Int64 BattleEnemyGroupId { get; set; }
        [Key(3)] public System.Int32 OrderNo { get; set; }
        [Key(4)] public System.Int64 DisplayConditionSetId { get; set; }
    }
}
