using System;
using System.Xml.Linq;

namespace Lab6CS
{
    class Program
    {
        static void Main(string[] args)
        {
            // for random data
            var range = 15;

            var rnd = new Random();
            var ProgressionList = new List<Progression>();
            try
            {
                Console.WriteLine("How much arythmetic progressions you'd like to set?");
                var ArythmCount = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < ArythmCount; i++)
                {
                    var ArythmProgression = new ArythmeticProgression(
                        // округлення до сотих + випадкові значення
                        Math.Round(rnd.NextDouble() * range, 2), Math.Round(rnd.NextDouble() * range, 2));
                    ProgressionList.Add(ArythmProgression);
                }

                Console.WriteLine("How much geometric progressions you'd like to set?");
                var GeomCount = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < GeomCount; i++)
                {
                    var GeomProgression = new GeometricProgression(
                        Math.Round(rnd.NextDouble() * range, 2), Math.Round(rnd.NextDouble() * range, 2));
                    ProgressionList.Add(GeomProgression);
                }

                foreach (var progression in ProgressionList)
                {
                    Console.WriteLine("Some progression information:");
                    progression.DisplayAll();
                    int n = 5;
                    Console.WriteLine($"n element of progression is: { progression.Element(n)}");
                    Console.WriteLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}