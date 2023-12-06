using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AutoBattleNotesRel
    {
        [Key(0)] public System.Int64 BattleId { get; set; }
        [Key(1)] public System.Int64 SkillNotesId { get; set; }
        [Key(2)] public System.Int32 OrderNo { get; set; }
    }
}
