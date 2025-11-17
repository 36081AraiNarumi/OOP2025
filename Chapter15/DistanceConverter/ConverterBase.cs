namespace DistanceConverter {
    public abstract class ConverterBase {
        public abstract bool IsMyUnit(string name);

        // メートルとの比率(この比率を掛けるとメートルに変換できる)
        protected abstract double Ratio { get; }

        // 距離の単位名(表示用)
        public abstract string UnitName { get; }

        // メートルから特定単位に変換
        public double FromMeter(double meter) => meter / Ratio;

        // 特定単位からメートルに変換
        public double ToMeter(double value) => value * Ratio;
    }
}
