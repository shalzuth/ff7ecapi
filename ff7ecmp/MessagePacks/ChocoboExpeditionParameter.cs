using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ChocoboExpeditionParameter
    {
        [Key(0)] public System.Int64 ChocoboExpeditionParameterGroupId { get; set; }
        [Key(1)] public System.Int32 ParameterType { get; set; }
        [Key(2)] public System.Int32 ParameterValue { get; set; }
        [Key(3)] public System.Int32 ExpeditionParameterValue { get; set; }
    }
}
