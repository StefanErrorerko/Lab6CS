using System;

namespace Lab6CS
{
    public class GeometricProgression : Progression
    {
        public double b1 { get; init; }
        public double q { get; init; }

        public GeometricProgression(double b1, double q)
        {
            this.b1 = b1;
            this.q = q;
        }

        public override double Element(int n)
        {
            return b1 * Math.Pow(q, n - 1);
        }

        public override void DisplayAll()
        {
            Console.WriteLine($"b1: {b1}");
            Console.WriteLine($"q: {q}");
        }
    }
}