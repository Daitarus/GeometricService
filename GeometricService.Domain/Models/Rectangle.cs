namespace GeometricService.Domain.Models
{
    public class Rectangle
    {
        private double _height = 0;
        public double Height
        {
            get { return _height; }
            set
            {
                if(value < 0) throw new ArgumentException($"{nameof(value)} must be greater 0", nameof(value));

                _height = value;
            }
        }

        private double _width = 0;
        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0) throw new ArgumentException($"{nameof(value)} must be greater 0", nameof(value));

                _width = value;
            }
        }
    }
}
