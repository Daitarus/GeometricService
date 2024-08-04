namespace GeometricService.Domain.Models
{
    public class Circle
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
    }
}
