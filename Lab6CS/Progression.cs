using System;

namespace Lab6CS
{
    public class Progression
    {
        public virtual double Element(int n)
        {
            return n;
        }
        public virtual void DisplayAll()
        {
            Console.WriteLine("Nothing");
        }
    }
}