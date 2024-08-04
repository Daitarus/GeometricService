using GeometricService.Domain.Models;
using GeometricService.Domain.Handlers.Interfaces;

namespace GeometricService.Domain.Handlers
{
    public class TriangleCalculationHandler : ICalculationAreaHandler<Triangle>
    {
        public double CalculateArea(Triangle figure)
        {
            if (figure == null) throw new ArgumentNullException(nameof(figure));

            return CalculateAreaForGeron(figure.Side1, figure.Side2, figure.Side3);
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
