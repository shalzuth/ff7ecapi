using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class AccessoryRecipe
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 AccessoryId { get; set; }
        [Key(2)] public System.Int64 AccessoryIngredientGroupId { get; set; }
        [Key(3)] public System.Int32 CraftGil { get; set; }
        [Key(4)] public System.Int64 DescriptionLanguageId { get; set; }
    }
}
