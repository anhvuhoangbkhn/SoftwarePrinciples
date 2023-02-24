using System;

namespace _3._1.LiskovSubtitutionBefore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public double GetTaxForArea(Rectangle area, double taxFree)
        {

            return area.AreaCalculator() * taxFree;
        }
    }
}
