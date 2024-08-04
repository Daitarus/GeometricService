namespace GeometricService.Domain.Handlers.Interfaces
{
    public interface ICalculationAreaHandler<T> where T : class
    {
        public double CalculateArea(T figure);
    }
}
