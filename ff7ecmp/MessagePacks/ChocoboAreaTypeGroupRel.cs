using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ChocoboAreaTypeGroupRel
    {
        [Key(0)] public System.Int64 ChocoboAreaTypeGroupId { get; set; }
        [Key(1)] public System.Int32 AreaType { get; set; }
    }
}
