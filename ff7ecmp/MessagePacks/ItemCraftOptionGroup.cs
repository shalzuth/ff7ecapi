using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ItemCraftOptionGroup
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 ItemId { get; set; }
        [Key(2)] public System.Int32 OrderNo { get; set; }
    }
}
