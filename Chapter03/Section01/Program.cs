namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("カウントしたい数値：");
            int input = int.Parse(Console.ReadLine());

            int result = Count(input);

            Console.WriteLine($"{input} は {result} 回出現します。");




        }
        static int Count(int num) {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            var count = 0;
            foreach (var n in numbers) {
                if(n == num) {
                    count++;
                }
            }
            return count;
        }
    }
}
