using MessagePack;
namespace Command.DB
{
    [MessagePackObject] public class MateriaParameter
    {
        [Key(0)] public System.Int64 Id { get; set; }
        [Key(1)] public System.Int32 ParameterType { get; set; }
        [Key(2)] public System.Int32 GrantValueType { get; set; }
        [Key(3)] public System.Int32 QualityOneMinEnhanceValue { get; set; }
        [Key(4)] public System.Int32 QualityOneMaxEnhanceValue { get; set; }
        [Key(5)] public System.Int32 QualityTwoMinEnhanceValue { get; set; }
        [Key(6)] public System.Int32 QualityTwoMaxEnhanceValue { get; set; }
        [Key(7)] public System.Int32 QualityThreeMinEnhanceValue { get; set; }
        [Key(8)] public System.Int32 QualityThreeMaxEnhanceValue { get; set; }
        [Key(9)] public System.Int32 QualityFourMinEnhanceValue { get; set; }
        [Key(10)] public System.Int32 QualityFourMaxEnhanceValue { get; set; }
        [Key(11)] public System.Int32 QualityFiveMinEnhanceValue { get; set; }
        [Key(12)] public System.Int32 QualityFiveMaxEnhanceValue { get; set; }
        [Key(13)] public System.Int32 QualityOneMinInitialValue { get; set; }
        [Key(14)] public System.Int32 QualityOneMaxInitialValue { get; set; }
        [Key(15)] public System.Int32 QualityTwoMinInitialValue { get; set; }
        [Key(16)] public System.Int32 QualityTwoMaxInitialValue { get; set; }
        [Key(17)] public System.Int32 QualityThreeMinInitialValue { get; set; }
        [Key(18)] public System.Int32 QualityThreeMaxInitialValue { get; set; }
        [Key(19)] public System.Int32 QualityFourMinInitialValue { get; set; }
        [Key(20)] public System.Int32 QualityFourMaxInitialValue { get; set; }
        [Key(21)] public System.Int32 QualityFiveMinInitialValue { get; set; }
        [Key(22)] public System.Int32 QualityFiveMaxInitialValue { get; set; }
    }
}
