using System.Globalization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            
            string in1 = Console.ReadLine();

            string in2 = Console.ReadLine();

            var cultureinfo = new CultureInfo("ja-JP");
            if (string.Equals(in1, in2, StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("等しい");
            } else {
                Console.WriteLine("等しくない");

            }
        }
    }
}
