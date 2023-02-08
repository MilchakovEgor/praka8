using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace wrireSpeedTest
{
    internal class class3
    {
        public static void Statistic_User(class4 statistic)
        {
            XmlSerializer xml = new XmlSerializer(typeof(class4));
            using (FileStream fs = new FileStream("C:\\Users\\egork\\Desktop\\testik.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, statistic);
            }
            Console.WriteLine("Успешно сохранилось");
        }
    }
}