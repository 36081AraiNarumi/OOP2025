using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LineCounter {
    internal class LineCounter{
        private int _count = 0;

        protected void Initialize(string fname) => _count = 0;

        protected void Execute (string line) => _count++;

        protected void Terminate() => Console.WriteLine("{0} 行", _count);
    }
}
