using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class TutorialConfig
    {
        [Key(0)] public System.Int32 Id { get; set; }
        [Key(1)] public System.Int64 EpisodeId { get; set; }
        [Key(2)] public System.Int64 StoryPartyId { get; set; }
        [Key(3)] public System.Int64 CraftMateriaRecipeId { get; set; }
        [Key(4)] public System.Int64 CraftMateriaId { get; set; }
        [Key(5)] public System.Int64 EvolveMateriaId { get; set; }
        [Key(6)] public System.Int64 TowerId { get; set; }
    }
}
