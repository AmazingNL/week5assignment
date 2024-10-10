

namespace week5assignment
{
    internal class Rectangle
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea(double width, double height) {
            return height * width;
        }

        public double CalculatePerimeter(double width, double height) { 
            return 2*(height + width);
        }
       
    }
}
