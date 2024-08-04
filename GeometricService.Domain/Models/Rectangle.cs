using GeometricService.Domain.Models.Abstracts;

namespace GeometricService.Domain.Models
{
    public class Rectangle : Figure
    {
        private double _height;
        public double Height
        {
            get { return _height; }
            set
            {
                if(value < 0) throw new ArgumentException($"{nameof(value)} must be greater 0", nameof(value));

                _height = value;
            }
        }

        private double _width;
        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0) throw new ArgumentException($"{nameof(value)} must be greater 0", nameof(value));

                _width = value;
            }
        }

        public Rectangle(double height, double wigth)
        {
            Height = height;
            Width = wigth;
        }

        public override double CalculateArea()
        {
            return _height * _width;
        }
    }
}
