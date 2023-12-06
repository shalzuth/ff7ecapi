using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ItemChocoboExpedition
    {
        [Key(0)] public System.Int64 ItemId { get; set; }
        [Key(1)] public System.Int64 ItemChocoboExpeditionCategoryId { get; set; }
    }
}
