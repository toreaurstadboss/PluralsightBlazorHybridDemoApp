using MauiApp1.Library.Data;
using System.Net.Http.Json;

namespace MauiApp1.Data;


public class CoffeeService : ICoffeeService
{
    private readonly HttpClient _httpClient = new(); 

    public async Task<IEnumerable<Coffee>?> LoadCoffeesAsync()
    {

        var coffees = await _httpClient.GetFromJsonAsync<IEnumerable<Coffee>?>(
            "https://www.thomasclaudiushuber.com/pluralsight/coffees.json");
        return coffees;


        //var coffees = new[]
        //{
        //    new Coffee("Cappuccino", "Coffee with milk foam"),
        //    new Coffee("Doppio", "Double espresso"),
        //};

        //var rnd = new Random();

        ////simulate some server work
        //await Task.Delay(rnd.Next(50,1500));
    }



}
