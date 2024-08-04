namespace GeometricService.Domain.Models
{
    public class Triangle
    {
        private double _side1 = 0;
        private double _side2 = 0;
        private double _side3 = 0;

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
    }
}
