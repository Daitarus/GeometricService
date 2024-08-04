using GeometricService.Domain.Models;
using GeometricService.Domain.Handlers.Interfaces;

namespace GeometricService.Domain.Handlers
{
    public class RectangleCalculationHandler : ICalculationAreaHandler<Rectangle>
    {
        public double CalculateArea(Rectangle figure)
        {
            if (figure == null) throw new ArgumentNullException(nameof(figure));

            return figure.Height * figure.Width;
        }
    }
}
