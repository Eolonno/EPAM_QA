using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int bounds = 500;
            List<DataProvider> dataProvider = new List<DataProvider>();
            for (int i = -bounds; i < bounds; i++)
            {
                for (int j = 0; j < bounds - i; j++)
                {
                    if (j != 0)
                        dataProvider.Add(new DataProvider(i, j, i - j));
                }
            }

            using (StreamWriter sw = new StreamWriter("Substract.txt"))
            {
                //XmlSerializer formatter = new XmlSerializer(dataProvider.GetType());
                //formatter.Serialize(sw, dataProvider);

                foreach (var data in dataProvider)
                {
                    sw.WriteLine("{0} {1} {2}", data.a, data.b, data.expected);
                }
                
            }

            //GetDataProvider("Sum.xml");
        }
        //public static List<DataProvider> GetDataProvider(string name)
        //{
        //    using (FileStream fs = new FileStream(@"../../../DataProviders/" + name, FileMode.Open))
        //    {
        //        XmlSerializer formatter = new XmlSerializer(typeof(DataProvider));
        //        return formatter.Deserialize(fs) as List<DataProvider>;
        //    }
        //}
    }

}
