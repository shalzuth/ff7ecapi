using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ItemTypeGroupRel
    {
        [Key(0)] public System.Int64 ItemTypeGroupId { get; set; }
        [Key(1)] public System.Int32 ItemType { get; set; }
    }
}
