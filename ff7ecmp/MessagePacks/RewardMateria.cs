using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class RewardMateria
    {
        [Key(0)] public System.Int64 RewardId { get; set; }
        [Key(1)] public System.Int32 QualityType { get; set; }
        [Key(2)] public System.Int64 NotesSetId { get; set; }
        [Key(3)] public System.Int32 ParameterOpenCount { get; set; }
        [Key(4)] public System.Int64 ParameterId0 { get; set; }
        [Key(5)] public System.Int64 ParameterId1 { get; set; }
        [Key(6)] public System.Int64 ParameterId2 { get; set; }
        [Key(7)] public System.Int64 ParameterId3 { get; set; }
        [Key(8)] public System.Int32 ParameterValue0 { get; set; }
        [Key(9)] public System.Int32 ParameterValue1 { get; set; }
        [Key(10)] public System.Int32 ParameterValue2 { get; set; }
        [Key(11)] public System.Int32 ParameterValue3 { get; set; }
    }
}
