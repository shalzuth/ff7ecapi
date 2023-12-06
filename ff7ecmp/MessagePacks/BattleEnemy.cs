using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleEnemy
    {
        [Key(0)] public System.Int64 EnemyGroupId { get; set; }
        [Key(1)] public System.Int64 Idx { get; set; }
        [Key(2)] public System.Int64 EnemyId { get; set; }
        [Key(3)] public System.Int32 Level { get; set; }
        [Key(4)] public System.Boolean IsTarget { get; set; }
        [Key(5)] public System.Int32 StatusDisplayType { get; set; }
        [Key(6)] public System.Int64 RewardSetId { get; set; }
        [Key(7)] public System.Boolean IsPickup { get; set; }
        [Key(8)] public System.Int32 RelocationLinkGroupNo { get; set; }
    }
}
