

namespace Figures
{
    public class Circle : Figure
    {
        public double Radius
        {
            get { return _radius; }
            set { if (value >= 0) _radius = value; else throw new ArgumentException("Side must be positive"); }
        }
        private double _radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double GetSquare()
        { 
            double result = Math.Round(Math.PI, 2)*Math.Pow(Radius, 2);
            result = Math.Round(result, 2);
            return result; 
        }
    }
}
