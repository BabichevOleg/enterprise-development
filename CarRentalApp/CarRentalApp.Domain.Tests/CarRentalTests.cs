using CarRentalApp.Domain;
namespace CarRentalApp.Domain.Tests;

public class CarRentalTests(TestDataProvider testDataProvider) : IClassFixture<TestDataProvider>
{
    private readonly TestDataProvider _testDataProvider = testDataProvider;

    //<summary>
    //ѕроверка возврата числа всех автомобилей.
    //</summary>
    [Fact]
    public void NumberOfCars()
    {
        var allCars = _testDataProvider.cars.ToList();
        Assert.Equal(6, allCars.Count);
    }

    //<summary>
    //ѕроверка возврата клиентов, арендовавших машину определенной модели.
    //</summary>
    [Fact]
    public void ClientsWhoHaveRentedCarsSpecialMarks()
    {
        string modelToSearch = "Model 2";
        var foundedClients = _testDataProvider.rentedCars
            .Where(r => r.Car!.Model == modelToSearch)
            .Select(r => r.Client)
            .Distinct()
            .OrderBy(c => c!.FullName)
            .ToList();
        Assert.Equal("Full name 4", foundedClients[0]!.FullName);
    }

    //<summary>
    //ѕроверка возврата автомобилей, наход€щихс€ в аренде.
    //</summary>
    [Fact]
    public void CarsInRent()
    {
        var foundedCars = _testDataProvider.rentedCars
            .Where(r => r.ReturnTime == null)
            .ToList();
        Assert.Equal(_testDataProvider.cars[0], foundedCars[0].Car);
        Assert.Equal(_testDataProvider.cars[4], foundedCars[1].Car);
        Assert.Equal(_testDataProvider.cars[3], foundedCars[2].Car);
    }

    //<summary>
    //ѕроверка возврата информации о топ-5 наиболее арендуемых автомобил€х.
    //</summary>
    [Fact]
    public void TopFiveCars()
    {
        var foundedCars = _testDataProvider.rentedCars
            .GroupBy(r => r.Car)
            .OrderByDescending(g => g.Count())
            .Take(5)
            .Select(g => g.Key)
            .ToList();
        Assert.Equal(_testDataProvider.cars[3], foundedCars[0]);
        Assert.Equal(_testDataProvider.cars[4], foundedCars[1]);
        Assert.Equal(_testDataProvider.cars[0], foundedCars[2]);
        Assert.Equal(_testDataProvider.cars[5], foundedCars[3]);
        Assert.Equal(_testDataProvider.cars[1], foundedCars[4]);
    }

    //<summary>
    //ѕроверка возврата количества аренд дл€ каждого автомобил€.
    //</summary>
    [Fact]
    public void NumbersOfRent()
    {
        var carsRentaCounts = _testDataProvider.rentedCars
            .GroupBy(r => r.Car.ID)
            .Select(g => new {Car = g.Key, CarNumber = g.First().Car.Number, Count = g.Count()})
            .OrderBy(x => x.CarNumber)
            .ToList();
        Assert.Equal(4, carsRentaCounts[0].Count);
        Assert.Equal(1, carsRentaCounts[1].Count);
        Assert.Equal(1, carsRentaCounts[2].Count);
        Assert.Equal(7, carsRentaCounts[3].Count);
        Assert.Equal(5, carsRentaCounts[4].Count);
        Assert.Equal(3, carsRentaCounts[5].Count);
    }

    /// <summary>
    /// ѕроверка возврата пунктов проката с максимальным числом аренд.
    /// </summary>
    [Fact]
    public void RentalPlaceWithMostRents()
    {
        var foundedRentalPlace = _testDataProvider.rentedCars
            .GroupBy(r => r.RentalPlace)
            .OrderByDescending(g => g.Count())
            .ThenBy(g => g.Key!.Name)
            .Select(g => g.Key)
            .Take(1)
            .ToList();
        Assert.Equal(_testDataProvider.rentalPlace[2], foundedRentalPlace[0]);
    }

}