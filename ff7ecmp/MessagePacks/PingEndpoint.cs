using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class PingEndpoint
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.String HostName { get; set; }
    }
}
