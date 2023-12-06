using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class BattleWave
    {
        [Key(0)] public System.Int64 WaveGroupId { get; set; }
        [Key(1)] public System.Int32 Idx { get; set; }
        [Key(2)] public System.Int64 EnemyGroupId { get; set; }
        [Key(3)] public System.Int64 RewardSetId { get; set; }
        [Key(4)] public System.Int64 BattleWaveTalkGroupSetId { get; set; }
        [Key(5)] public System.Int64 ResourceId { get; set; }
        [Key(6)] public System.String EnterCutsceneName { get; set; }
        [Key(7)] public System.String ExitCutsceneName { get; set; }
        [Key(8)] public System.String BgmCueName { get; set; }
        [Key(9)] public System.String PostEnterMovieName { get; set; }
        [Key(10)] public System.String PreExitMovieName { get; set; }
    }
}
