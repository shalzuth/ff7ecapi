using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MaintenanceExtension
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 StartDatetime { get; set; }
        [Key(2)] public System.Int32 ExtensionMinutes { get; set; }
    }
}
