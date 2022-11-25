using System;

namespace Lab6CS
{
    public class ArythmeticProgression : Progression
    {
        public double a1 { get; init; }
        public double d { get; init; }

        public ArythmeticProgression(double a1, double d)
        {
            this.a1 = a1;
            this.d = d;
        }

        public override double Element(int n)
        {
            return a1 + d * (n - 1);
        }

        public override void DisplayAll()
        {
            Console.WriteLine($"a1: { a1}");
            Console.WriteLine($"d: { d}");
        }

    }
}