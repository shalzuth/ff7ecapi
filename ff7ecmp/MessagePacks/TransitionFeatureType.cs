using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class TransitionFeatureType
    {
        [Key(0)] public System.Int32 TransitionType { get; set; }
        [Key(1)] public System.Int32 FeatureType { get; set; }
    }
}
