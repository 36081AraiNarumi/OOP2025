using System.Runtime.CompilerServices;

namespace ProductSample{
    internal class Program{
        static void Main(string[] args){

           Product karinto = new Product(123, "かりんとう", 180);
            Product daifuku = new Product(123, "だいふこ", 325);



            //税抜きの価格を表示【かりんとうの税抜き価格は○○円です】

            Console.WriteLine(karinto.Name + "の税抜き価格は" + karinto.Price + "です。");

            //消費税額の表示【かりんとうの消費税額は○○円です】
            Console.WriteLine(karinto.Name + "の消費税額は" + karinto.GetTax() + "です。");
            //税込みの表示【かりんとうのぜいこみ価格は○○円です】
            Console.WriteLine(karinto.Name + "の税込み価格は" + karinto.GetPriceIncludingTax() + "円です");

           // 税抜きの価格を表示【かりんとうの税抜き価格は○○円です】

            Console.WriteLine(daifuku.Name + "の税抜き価格は" + daifuku.Price + "です。");

            //消費税額の表示【かりんとうの消費税額は○○円です】
            Console.WriteLine(daifuku.Name + "の消費税額は" + daifuku.GetTax() + "です。");
            //税込みの表示【かりんとうのぜいこみ価格は○○円です】
            Console.WriteLine(daifuku.Name + "の税込み価格は" + daifuku.GetPriceIncludingTax() + "円です");
        }
    }
}
