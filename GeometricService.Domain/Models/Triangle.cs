using GeometricService.Domain.Models.Abstracts;

namespace GeometricService.Domain.Models
{
    public class Triangle : Figure
    {
        private double _side1;
        private double _side2;
        private double _side3;

        public double Side1 
        { 
            get { return _side1; } 
            set 
            {
                if (value < 0) throw new ArgumentException($"{nameof(value)} must be greater 0", nameof(value));

                _side1 = value; 
            } 
        }

        public double Side2
        {
            get { return _side2; }
            set
            {
                if (value < 0) throw new ArgumentException($"{nameof(value)} must be greater 0", nameof(value));

                _side2 = value;
            }
        }

        public double Side3
        {
            get { return _side3; }
            set
            {
                if (value < 0) throw new ArgumentException($"{nameof(value)} must be greater 0", nameof(value));

                _side2 = value;
            }
        }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double CalculateArea()
        {
            return CalculateAreaForGeron(_side1, _side2, _side3);
        }

        private double CalculateAreaForGeron(double side1, double side2, double side3)
        {
            var sd = CalculateSemiperimeter(side1, side2, side3);
            return Math.Sqrt(sd * (sd - side1) * (sd - side2) * (sd - side3));
        }

        private double CalculateSemiperimeter(double side1, double side2, double side3)
        {
            return (side1 + side2 + side3) / 2;
        }
    }
}
