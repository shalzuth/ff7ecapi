using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AnotherBattleRel
    {
        [Key(0)] public System.Int64 AnotherBattleId { get; set; }
        [Key(1)] public System.Int32 BossEnhanceStage { get; set; }
        [Key(2)] public System.Int64 BattleId { get; set; }
        [Key(3)] public System.Int32 OrderNo { get; set; }
    }
}
