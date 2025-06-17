using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売上集計クラス
    public class SalesCounter {
        private readonly List<Sale> _sales;

        //コンストラクタ
        public SalesCounter(List<Sale> sales) {
            sales = sales;
        }

        //店舗別の売り上げを求める
        public Dictionary<string,int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
                
            }
            return dict;
        }

    }
}
