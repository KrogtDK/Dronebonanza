using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DroneData
    // 1. git add .             //
    // 2. git commit -m "XXX"   //
    // 3. git push origin master//
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"C:\Users\Oliver N. Jensen\Desktop\04. Manupulation af tekststrenge c#/flyvning1.csv";
            // "Lånet" fra Patrick//

            using (var reader = new StreamReader(Path))
            {
                List<string>[] List = new List<string>[14];
                    
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    List[1] = values[1];

                }
            }
            Console.ReadKey();
        }
    }
}
