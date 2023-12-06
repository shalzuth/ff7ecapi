using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleWaveTalk
    {
        [Key(0)] public System.Int64 BattleWaveTalkGroupId { get; set; }
        [Key(1)] public System.Int32 Seq { get; set; }
        [Key(2)] public System.String PrinterName { get; set; }
        [Key(3)] public System.Int64 CharacterNovelSetId { get; set; }
        [Key(4)] public System.Int64 TalkLanguageId { get; set; }
        [Key(5)] public System.Int64 NameLanguageId { get; set; }
    }
}
