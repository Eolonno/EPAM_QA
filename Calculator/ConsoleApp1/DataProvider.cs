using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    public class DataProvider
    {
        public int a { get; set; }
        public int b { get; set; }
        public int expected { get; set; }

        public DataProvider(int A, int B, int Expected)
        {
            a = A;
            b = B;
            expected = Expected;
        }

        public DataProvider()
        {
            
        }
    }
}
