namespace GeometricService.Domain.Services.Interfaces
{
    public interface IGeometricCalculationService<T> where T : class
    {
        public double CalculateArea(T figure);
    }
}
