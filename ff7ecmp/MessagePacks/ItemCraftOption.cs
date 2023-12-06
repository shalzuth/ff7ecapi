using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ItemCraftOption
    {
        [Key(0)] public System.Int64 ItemId { get; set; }
        [Key(1)] public System.Int32 Point { get; set; }
        [Key(2)] public System.Int32 MaxUseCount { get; set; }
    }
}
