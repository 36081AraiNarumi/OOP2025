namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            List<IGretting> list = [
                new GrettingMorning(),
                new GrettingAfternoon(),
                new GrettingEvening(),
                ];

            foreach (var obj in list) {
                string msg = obj.GetMessage();
                Console.WriteLine(msg);
            }
        }
    }


    class GrettingMorning : IGretting {
        public string GetMessage() => "おはよう";
    }

    class GrettingAfternoon : IGretting {
        public string GetMessage() => "こんにちは";
    }

    class GrettingEvening : IGretting {
        public string GetMessage() => "こんばんは";
    }
}
