
using System.Text;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

        }

        private static void Exercise1(string text) {
            var spaces = text.Count(c => c == ' ');
           // var count = text.Count(char.IsWhiteSpace);
            Console.WriteLine($"空白数:{spaces}");
        }

        private static void Exercise2(string text) {
            var replace = text.Replace("big", "small");
            Console.WriteLine(replace);
        }

        private static void Exercise3(string text) {
            var array = text.Split(' ');
            var sp = new StringBuilder();
            foreach (var word in array) {           
                sp.Append(word + ".");
            }
            Console.WriteLine();

            
        }

        private static void Exercise4(string text) {

            var count = text.Split(" ").Length;
            Console.WriteLine($"単語数:{count}");
                
        }

        private static void Exercise5(string text) {
            var words = text.Split(' ');
            var sWord = words.Where(word => word.Length <= 4);
            
            foreach (var word in sWord) {
                Console.WriteLine(word);
            }
        }
    }
}
