namespace _3._2.LiskovSubtitutionAfter {
    internal class Rectange : IShape {

        public int Width;
        public int Height;

        public Rectange(int width, int height)
        {
            Width = width;
            Height = height;
        }

       
        public double AreaCalculator()
        {
            return Width * Height;
        }
    }
}
