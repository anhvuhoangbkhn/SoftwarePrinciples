namespace _3._1.LiskovSubtitutionBefore
{
    public class Rectangle
    {
        public int Width;
        public int Height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double AreaCalculator()
        {
            return Width * Height;
        }
    }
}
