namespace Test01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }

        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            var sales = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach(var line in lines) {
                string[] items = line.Split(',');
                
                Student student = new Student() {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                sales.Add(student);


            }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {





        }
    }
}
