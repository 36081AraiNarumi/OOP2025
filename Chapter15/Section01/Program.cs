namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            List<GrettingBase> list = new List<GrettingBase> {
                new GrettingMorning(),
                new GrettingAfternoon(),
                new GrettingEvening(),
            };

            foreach (var obj in list) {
                string msg = obj.GetMessage();
                Console.WriteLine(msg);
            }
        }
    }


    class GrettingMorning : GrettingBase {
        public override string GetMessage() => "おはよう";
    }

    class GrettingAfternoon : GrettingBase {
        public override string GetMessage() => "こんにちは";
    }

    class GrettingEvening : GrettingBase {
        public override string GetMessage() => "こんばんは";
    }
}
