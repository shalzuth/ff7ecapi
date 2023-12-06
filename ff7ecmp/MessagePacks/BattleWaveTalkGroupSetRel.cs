using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleWaveTalkGroupSetRel
    {
        [Key(0)] public System.Int64 BattleWaveTalkGroupSetId { get; set; }
        [Key(1)] public System.Int32 TimingType { get; set; }
        [Key(2)] public System.Int64 BattleWaveTalkGroupId { get; set; }
    }
}
