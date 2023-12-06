using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaRecipe
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 MateriaId { get; set; }
        [Key(2)] public System.Int32 ItemRarityType { get; set; }
        [Key(3)] public System.Int64 NotesSetId { get; set; }
        [Key(4)] public System.Int64 MateriaIngredientGroupId { get; set; }
        [Key(5)] public System.Int32 CraftGil { get; set; }
        [Key(6)] public System.Int64 TitleLanguageId { get; set; }
        [Key(7)] public System.Int64 DescriptionLanguageId { get; set; }
        [Key(8)] public System.Int64 ResourceId { get; set; }
        [Key(9)] public System.Int64 MateriaCraftOptionGroupId { get; set; }
        [Key(10)] public System.Int64 ItemCraftOptionGroupId { get; set; }
    }
}
