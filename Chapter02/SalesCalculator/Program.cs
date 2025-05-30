﻿namespace SalesCalculator {
    internal class Program {
        static void Main(string[] args) {
            SalesCounter sales = new SalesCounter(ReadSales(@"data\sales.csv"));
            Dictionary<string, int> amountsPerStore = sales.GetPerStoreSales();
            foreach(KeyValuePair<string,int> obj in amountsPerStore) {
                Console.WriteLine($"{obj.Key}{obj.Value}");
            }



            ReadSales(@"data\sales.csv");
        }

        //売上データ読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(string filePath) {
            //売上データを入れるリストオブジェクトを生成
            List<Sale> sales = new List<Sale>();
            //ファイルを一気に読み込み
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                //Saleオブジェクトを生成
                Sale sale = new Sale() {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2]),
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}
