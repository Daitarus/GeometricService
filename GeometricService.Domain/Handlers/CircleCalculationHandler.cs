using GeometricService.Domain.Models;
using GeometricService.Domain.Handlers.Interfaces;

namespace GeometricService.Domain.Handlers
{
    public class CircleCalculationHandler : ICalculationAreaHandler<Circle>
    {
        public double CalculateArea(Circle figure)
        {
            if (figure == null) throw new ArgumentNullException(nameof(figure));

            return Math.PI * Math.Pow(figure.Radius, 2);
        }
    }
}
