using System;

namespace TextFileProcessorDI {
    internal class Program {
        static void Main(string[] args) {
            // ★ 20行だけ表示するサービス
            var service = new LineOutputService();

            // （もし行数を数えたいなら）
            // var service = new LineCounterService();

            var processor = new TextFileProcessor(service);

            Console.Write("パスの入力：");
            var path = Console.ReadLine();

            processor.Run(path);
        }
    }
}
