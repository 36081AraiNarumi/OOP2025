
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            int[] numbers = [5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35];

            Console.WriteLine("7.1.1");
            Exercise1(numbers);

            Console.WriteLine("7.1.2");
            Exercise2(numbers);

            Console.WriteLine("7.1.3");
            Exercise3(numbers);

            Console.WriteLine("7.1.4");
            Exercise4(numbers);

            Console.WriteLine("7.1.5");
            Exercise5(numbers);
        }

        private static void Exercise1(int[] numbers) {
            int max = numbers.Max();
            Console.WriteLine($"{max}");
        }

        private static void Exercise2(int[] numbers) {
            //var lastTwo = numbers.TakeLast(2).ToArray();
            //Console.WriteLine($"{string.Join(", ", lastTwo)}");
            foreach (var n in numbers.TakeLast(2)) {
                Console.WriteLine(n);
            }
        }

        private static void Exercise3(int[] numbers) {
            var strs = numbers.Select(n => n.ToString(""));
            foreach (var s in strs) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise4(int[] numbers) {
            Array.Sort(numbers);
            for (int i = 0; i < 3; i++) {
                Console.WriteLine(numbers[i]);
            }
        }

        private static void Exercise5(int[] numbers) {
            var count = numbers.Distinct().Where(n => n >= 10).Count();
        }
    }
}
