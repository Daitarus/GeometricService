using GeometricService.Domain.Models.Abstracts;

namespace GeometricService.Domain.Models
{
    public class Circle : Figure
    {
        private double _radius;
        public double Radius 
        { 
            get {  return _radius; }
            set
            {
                if (value < 0) throw new ArgumentException($"{nameof(value)} must be greater 0", nameof(value));

                _radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
