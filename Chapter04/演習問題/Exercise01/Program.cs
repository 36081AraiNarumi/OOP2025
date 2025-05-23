
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
                "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
        }
        //foreach文
        private static void Exercise1(List<string> langs) {
            foreach (var lang in langs) {
                if (lang.Contains('S')) 
                    Console.WriteLine(lang);    
            }
            Console.WriteLine();

            //for文
            for (int i = 0; i < langs.Count; i++) {
                if (langs.Contains("S"))
                    Console.WriteLine(langs);
            }

            //while文
            int index = 0;
            while (index < langs.Count) {
                if (langs[index].Contains('S')) 
                    Console.WriteLine(langs[index]);
                index++;
            }
		}
        private static void Exercise2(List<string> langs) {
            var selected = langs.Where(x => x.Contains('S'));
            foreach (var lang in selected) {
                Console.WriteLine(lang);
            }
        }
        //2行で完成させる
        private static void Exercise3(List<string> langs) {
            Console.WriteLine(langs.Find(x => x.Length == 10 ?? "unknown");



        }
    }
}
