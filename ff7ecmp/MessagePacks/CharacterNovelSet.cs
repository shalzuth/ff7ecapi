using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class CharacterNovelSet
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int64 NameLanguageId { get; set; }
        [Key(2)] public System.Int64 CharacterNovelId { get; set; }
        [Key(3)] public System.Int64 CharacterNovelCostumeId { get; set; }
        [Key(4)] public System.String VariationType { get; set; }
        [Key(5)] public System.Int64 RegisterId { get; set; }
    }
}
