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
            // Gemmer adressen på filen vi vil kopiere data fra i en string kaldet "Path" (Lånet af Patrick) //
            string Path = @"C:\Users\Oliver N. Jensen\Desktop\04. Manupulation af tekststrenge c#/flyvning1.csv";

            // Laver en ny StreamReader kaldet "reader" som læser fra "Path" //
            using (var reader = new StreamReader(Path))
            {
                // Laver en ny array af lister med 14 lister kaldet "List" //
                List<string>[] List = new List<string>[14];

                for (int e = 0; e < 14; e++)
                {
                    // Laver en nye lister og tilføjer dem til "List" //
                    List[e] = new List<string> { };
                }

                // While loop der kører så længe at "reader" ikke er færdig med at læse //
                while (!reader.EndOfStream)
                {
                    // Tager og gemmer linjen som "reader" lige har læst som "Line" //
                    var line = reader.ReadLine();
                    // Separerer "Line" hver gang der er en ; og gemmer dem som "values" //
                    var values = line.Split(';');

                    for (int o = 0; o < 13; o++)
                    {
                        // Tilføjer ord fra "values" til listerne i "List" //
                        List[o].Add(values[o]);
                    }
                }

                    for (int q = 0; q < 14; q++)
                {
                    if (q == 2)
                    {
                        // For loop der kører samme mængde gange som listens længde //
                        for (int q2 = 2; q2 < List[2].Count; q2++)
                        {
                            // Fjerner punktomer fra ord i listen //
                            List[2][q2] = List[2][q2].Replace(".", string.Empty);
                            // Sætter et punktom ind imellem første og andet tegn i ordet. //
                            List[2][q2] = List[2][q2].Insert(1, ".");
                        }
                    }
                    if (q == 3)
                    {
                        // For loop der kører samme mængde gange som listens længde //
                        for (int q3 = 2; q3 < List[3].Count; q3++)
                        {
                            // Fjerner punktomer //
                            List[3][q3] = List[3][q3].Replace(".", string.Empty);
                            
                            // Tilføjer punktomer imellem første og anden tegn //
                            List[3][q3] = List[3][q3].Insert(2, ".");
                        }
                    }
                    if (q == 13)
                    {
                        // Skriver GPSKoord i første række i sidste kolonne //
                        List[13].Add("GPSKoord");
                        
                        // Laver et tomt felt i anden række af sidste kolonne //
                        List[13].Add("");

                        // For loop der kører samme mængde gange som listens længde //
                        for (int q13 = 2; q13 < List[2].Count; q13++)
                        {
                            // Tager data fra tredje og fjere kolonne og sætter dem sammen, separeret af et komma //
                            List[13].Add(List[2][q13] + "," + List[3][q13]);
                        }
                        
                    }
                }
                // Laver en ny strigbuilder kaldet "Data" //
                StringBuilder Data = new StringBuilder();

                // For loop der kører 5359 gange //
                for (int Æ = 0; Æ < 5359; Æ++)
                {
                    // Tager ord fra "List" og sætter dem sammen med semikolon og andre ord om og om igen //
                    Data.AppendLine(List[0][Æ] + ";" + List[1][Æ] + ";" + List[2][Æ] + ";" + List[3][Æ] + ";" + List[4][Æ] + ";" + List[5][Æ] + ";" + List[6][Æ] + ";" + List[7][Æ] + ";" + List[8][Æ] + ";" + List[9][Æ] + ";" + List[10][Æ] + ";" + List[11][Æ] + ";" + List[12][Æ] + ";" + List[13][Æ] + ";");
                }
                
                // Laver en ny .csv fil og sætter alt fra "Data" ind som tekst //
                File.WriteAllText(@"C:\Users\Oliver N. Jensen\Desktop\04. Manupulation af tekststrenge c#/flyvning2.csv", Data.ToString());    
            }
        Console.ReadKey();
        }
    }
}
