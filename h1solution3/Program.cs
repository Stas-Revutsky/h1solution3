using System.Xml.Linq;

namespace h1solution3
{
    internal class Program
    {
        static double CalculateLength(double radius)
        {
            return Math.PI * radius * 2;
        }
        static double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double CalculateVolume(double radius)
        {
            double sphereVolumeKoefficient = 4 / 3;
            return Math.PI * (Math.Pow(radius, 3)) * sphereVolumeKoefficient;
        }
        static void Main(string[] args)
        {
            double r;
            do
            {
                Console.WriteLine("Please enter radius");
            }
            while (!double.TryParse(Console.ReadLine(), out r));

            Console.WriteLine($"The length is {CalculateLength(r)}{
                Environment.NewLine}the area is {CalculateArea(r)}{
                Environment.NewLine}the volume is{CalculateVolume(r)}");
        }
    }
}