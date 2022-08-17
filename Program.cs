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

                for (int e = 0; e < 14; e++)
                {
                    List[e] = new List<string> { };
                }
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    for (int o = 0; o < 13; o++)
                    {
                        List[o].Add(values[o]);
                    }
                }


                    for (int q = 0; q < 14; q++)
                {
                    if (q == 2)
                    {
                        for (int q2 = 2; q2 < List[2].Count; q2++)
                        {
                            List[2][q2] = List[2][q2].Replace(".", string.Empty);
                                
                            List[2][q2] = List[2][q2].Insert(5, ".");
                            List[2][q2] = List[2][q2].Insert(2, ".");
                            Console.WriteLine(List[2][q2]);
                        }
                    }
                    if (q == 3)
                    {
                        for (int q3 = 2; q3 < List[3].Count; q3++)
                        {
                            List[3][q3] = List[3][q3].Replace(".", string.Empty);

                            if (List[3][q3].Length == 9)
                            {
                                List[3][q3] = List[3][q3].Insert(6, ".");
                                List[3][q3] = List[3][q3].Insert(3, ".");
                            }
                            else
                            {
                                List[3][q3] = List[3][q3].Insert(5, ".");
                                List[3][q3] = List[3][q3].Insert(2, ".");
                            }
                                
                            Console.WriteLine(List[3][q3]);
                        }
                    }
                    if (q == 13)
                    {
                        List[13].Add("GPSKoord");
                        List[13].Add("");

                        for (int q13 = 2; q13 < List[2].Count; q13++)
                        {
                            List[13].Add(List[2][q13] + "," + List[3][q13]);
                            Console.WriteLine(List[13][q13]);
                        }
                        
                    }
                }
                    
            }
        Console.ReadKey();
        }
    }
}
