namespace MauiApp1.Data
{
    public interface ICoffeeService
    {
        Task<IEnumerable<Coffee>?> LoadCoffeesAsync();
    }
}