using System;

namespace _3._2.LiskovSubtitutionAfter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public double GetTaxForArea ( IShape area, double taxFree ) {

            return area.AreaCalculator( ) * taxFree;
        }
    }
}
