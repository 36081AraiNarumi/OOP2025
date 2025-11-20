namespace TextFileProcessorDI {
    public interface ITextFileService {
        void Initialize(string name);
        void Execute(string line);
        void Terminate();
    }
}
