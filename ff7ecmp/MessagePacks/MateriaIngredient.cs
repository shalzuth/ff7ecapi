using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaIngredient
    {
        [Key(0)] public System.Int64 MateriaIngredientGroupId { get; set; }
        [Key(1)] public System.Int64 ItemId { get; set; }
        [Key(2)] public System.Int32 Count { get; set; }
    }
}
