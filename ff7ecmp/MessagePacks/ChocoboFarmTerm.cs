using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ChocoboFarmTerm
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 OffsetStartDatetime { get; set; }
        [Key(2)] public System.Int64 ResetId { get; set; }
    }
}
