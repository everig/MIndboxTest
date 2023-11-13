
namespace Figures
{
    public class Triangle : Figure
    {
        public double SideA 
        {
            get { return _sideA; }
            set { if (value >= 0) _sideA = value; else throw new ArgumentException("Side must be positive"); } 
        }
        private double _sideA;
        public double SideB 
        {
            get { return _sideB; }
            set { if (value >= 0) _sideB = value; else throw new ArgumentException("Side must be positive"); }
        }
        private double _sideB;
        public double SideC 
        {
            get { return _sideC; }
            set { if (value >= 0) _sideC = value; else throw new ArgumentException("Side must be positive"); }
        }
        private double _sideC;
        private double HalfPerimetr;
        public Triangle (double SideA, double SideB, double SideC)
        {
            this.SideA = SideA; 
            this.SideB = SideB; 
            this.SideC = SideC;
            HalfPerimetr = Math.Round((SideA + SideB + SideC)/2, 2);
        }

        public override double GetSquare()
        {
            double result = Math.Sqrt(HalfPerimetr * (HalfPerimetr - SideA) * (HalfPerimetr - SideB) * (HalfPerimetr - SideC));
            result = Math.Round(result, 2);
            return result;
        }
        
        public bool RightTriangle()
        {
            List<double> list = new List<double>() { SideA, SideB, SideC };
            double max = Enumerable.Max<double>(list);

            if ((Math.Pow(SideA, 2) + Math.Pow(SideB, 2) + Math.Pow(SideC, 2) - Math.Pow(max, 2)) == Math.Pow(max, 2))
                return true;
            else return false;
        }
    }
}
