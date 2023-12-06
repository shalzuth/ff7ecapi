using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class ItemMateriaEnhanceIngredient
    {
        [Key(0)] public System.Int64 ItemId { get; set; }
        [Key(1)] public System.Int32 Exp { get; set; }
    }
}
