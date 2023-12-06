using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaEvolveSetting
    {
        [Key(0)] public System.Int64 MateriaEvolveSettingGroupId { get; set; }
        [Key(1)] public System.Int64 EvolveCount { get; set; }
        [Key(2)] public System.Int32 LevelLimit { get; set; }
        [Key(3)] public System.Int64 MateriaIngredientGroupId { get; set; }
        [Key(4)] public System.Int32 ConsumptionGil { get; set; }
    }
}
