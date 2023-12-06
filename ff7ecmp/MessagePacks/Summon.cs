using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Summon
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 SummonPieceItemId { get; set; }
        [Key(2)] public System.Int64 ResourceId { get; set; }
        [Key(3)] public System.Int64 NameLanguageId { get; set; }
        [Key(4)] public System.Int32 OrderNo { get; set; }
        [Key(5)] public System.Int64 DefaultSkillSpecialId { get; set; }
        [Key(6)] public System.Int64 StartDatetime { get; set; }
    }
}
