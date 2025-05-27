

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1();
            Console.WriteLine("---");
            Exercise2();
            Console.WriteLine("---");
            Exercise3();
        }

        private static void Exercise1() {
            Console.WriteLine("数値を入力してください");
            var line = Console.ReadLine(); 
            if(int.TryParse(line, out var num)) {
                if(num < 0) {
                    Console.WriteLine(num);   
                }
            } else {
                Console.WriteLine("入力値に誤りがあります");

            }
        }

        private static void Exercise2() {
            var line = Console.ReadLine();
            if(int.TryParse(line, out var num)) {
                switch (num) {
                    case < 0;
                                    }
            }
        }

        private static void Exercise3() {
            var line = Console.ReadLine();
            if (int.Parse(line, out var num)) {

            }
            
        }
    }
}
