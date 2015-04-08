namespace Shapes
{
    public class Triangle : Shape
    {
        private const int Half = 2;

        public Triangle(double width, double height)
            : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / Half;
        }
    }
}
