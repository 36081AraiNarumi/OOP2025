using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var datetime = DateTime.Now;
            DisplayDatePattern1(datetime);
            DisplayDatePattern2(datetime);
            DisplayDatePattern3(datetime);
        }
        private static void DisplayDatePattern1(DateTime datetime) {
            //2024/03/09 19:03
            //string.Formatを使った例
            string str = string.Format($"{datetime:yyyy/MM/dd HH:mm}");
            Console.WriteLine(str);
        }
        private static void DisplayDatePattern2(DateTime datetime) {
            //2024/03/09 19時03分09秒
            //Datetime.ToStringを使った例
            string str = datetime.ToString($"{datetime:yyyy年MM月dd日 HH時mm分ss秒}");
            Console.WriteLine(str);

        }
        private static void DisplayDatePattern3(DateTime datetime) {
            
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = datetime.ToString("ggyy年M月d日",culture);
            var dayOfWeek = culture.DateTimeFormat.GetDayName(datetime.DayOfWeek);

            Console.WriteLine($"{str}({dayOfWeek})");
            

        }

    }
}
