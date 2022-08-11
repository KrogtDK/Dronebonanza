using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DroneData
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"C:\Users\Oliver N. Jensen\Desktop\04. Manupulation af tekststrenge c#/flyvning1.csv";
            using (var reader = new StreamReader(Path))
            {
                List<string> ListTicks = new List<string>();
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    ListTicks.Add(values[0]);
                }
                for (int i = 2; i < ListTicks.Count; i++)
                {
                    Console.WriteLine(ListTicks[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
