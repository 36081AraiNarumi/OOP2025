using System.Linq;

namespace DistanceConverter {
    public class ConverterFactory {
        // 利用可能な全単位をここに登録
        private readonly static ConverterBase[] _converters = {
            new MeterConverter(),
            new FeetConverter(),
            new YardConverter(),
            new InchConverter(),
            new MileConverter(),
            new KilometerConverter()
        };

        public static ConverterBase? GetInstance(string name) =>
            _converters.FirstOrDefault(x => x.IsMyUnit(name));
    }
}
