using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class YearMonth {
        //5.1.1
        public int Year { get; set; }
        public int Month { get; set; }
        public YearMonth(int Year, int Month) {
            this.Year = Year;
            this.Month = Month;   
        }
        //5.1.2
        //設定されている西暦が21世紀か判断する
        //Yearが2001～2100年の間ならtrue,それ以外ならfalseを返す
        public bool Is21Century=>
            if (true)
	{

	}



        //4.1.3
        public YearMonth AddOneMonth() {

        }
        //4.1.4
        public override string ToString() =>
            
        
    }
}
