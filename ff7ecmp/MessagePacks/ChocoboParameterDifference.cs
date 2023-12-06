using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ChocoboParameterDifference
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ChocoboParameterDifferenceGroupId { get; set; }
        [Key(2)] public System.Int32 ParameterDifferenceRangeValueBp { get; set; }
        [Key(3)] public System.Int32 Weight { get; set; }
    }
}
