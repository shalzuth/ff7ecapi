using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class SkillParameterUp
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 ParameterType { get; set; }
        [Key(2)] public System.Int32 ParameterUpCoefficient { get; set; }
        [Key(3)] public System.Int32 FixedValue { get; set; }
    }
}
