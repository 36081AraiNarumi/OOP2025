using System;

namespace TextFileProcessorDI {
    public class LineOutputService : ITextFileService {
        private int _lineCount;

        public void Initialize(string name) {
            _lineCount = 0;
        }

        public void Execute(string line) {
            if (_lineCount < 20) {
                Console.WriteLine(line);
                _lineCount++;
            }
        }

        public void Terminate() {
            // 処理なし
        }
    }
}
