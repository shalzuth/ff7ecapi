using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AnotherBattle
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 AnotherDungeonId { get; set; }
        [Key(2)] public System.Int64 RewardSetId { get; set; }
        [Key(3)] public System.Int64 AfterBattleDropRewardSetId { get; set; }
        [Key(4)] public System.Int64 DungeonBuffDebuffSelectId { get; set; }
        [Key(5)] public System.Int32 BattleType { get; set; }
        [Key(6)] public System.Int64 PremiseAnotherBattleId { get; set; }
        [Key(7)] public System.Int32 Idx { get; set; }
        [Key(8)] public System.Boolean IsDisplayInfo { get; set; }
    }
}
