using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class DungeonBuffDebuff
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 BufDebuffType { get; set; }
        [Key(2)] public System.Int64 NameLanguageId { get; set; }
    }
}
