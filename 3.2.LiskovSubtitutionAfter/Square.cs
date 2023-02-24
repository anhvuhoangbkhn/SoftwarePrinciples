namespace _3._2.LiskovSubtitutionAfter {
    internal class Square : IShape {

        public int Side;

        public Square(int side)
        {
            this.Side = side;
        }

        public double AreaCalculator()
        {
            return Side * Side;
        }
    }
}
