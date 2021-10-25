using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CalculatorClassLibrary.Tests
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

        public static List<DataProvider> GetDataProvider(string name)
        {
            List<DataProvider> dataProvider = new List<DataProvider>();
            using (StreamReader fs = new StreamReader(@"../../../DataProviders/" + name))
            {
                while (!fs.EndOfStream)
                {
                    var data = fs.ReadLine().Split(" ");
                    dataProvider.Add(new DataProvider(Convert.ToInt32(data[0]),
                                                          Convert.ToInt32(data[1]),
                                                          Convert.ToInt32(data[2])));
                }
            }

            return dataProvider;
        }
    }
}
