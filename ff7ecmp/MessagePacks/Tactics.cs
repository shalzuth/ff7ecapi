using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class Tactics
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 TacticsType { get; set; }
        [Key(2)] public System.Int32 WaitMsec { get; set; }
        [Key(3)] public System.Int32 MaxGaugeSpeed { get; set; }
        [Key(4)] public System.Int64 NameLanguageId { get; set; }
    }
}
