namespace CarRentalApp.Domain.Tests;

public class CarRentalTest(TestDataProvider testDataProvider) : IClassFixture<TestDataProvider>
{
    private readonly TestDataProvider _testDataProvider = testDataProvider;

    //<summary>
    //Проверка возврата всех автомобилей.
    //</summary>
    [Fact]
    public void NumberOfCars()
    {
        var allCars = _testDataProvider.Cars.ToList();
        Assert.Equal(6, allCars.Count);
    }

    //<summary>
    //Проверка возврата клиентов, арендовавших машину определенной модели.
    //</summary>
    [Fact]
    public void ClientsWhoHaveRentedCarsSpecialMarks()
    {
        var modelToSearch = "Model 2";
        var foundedClients = _testDataProvider.RentedCars
            .Where(r => r.Car.Model == modelToSearch)
            .Select(r => r.Client)
            .Distinct()
            .OrderBy(c => c.FullName)
            .ToList();
        Assert.Equal("Full name 4", foundedClients[0]!.FullName);
    }

    //<summary>
    //Проверка возврата автомобилей, находившихся в аренде.
    //</summary>
    [Fact]
    public void CarsInRent()
    {
        var foundedCars = _testDataProvider.RentedCars
            .Where(r => r.ReturnTime == null)
            .ToList();
        Assert.Equal(_testDataProvider.Cars[0], foundedCars[0].Car);
        Assert.Equal(_testDataProvider.Cars[4], foundedCars[1].Car);
        Assert.Equal(_testDataProvider.Cars[3], foundedCars[2].Car);
    }

    //<summary>
    //Проверка возврата информации о топ-5 наиболее арендуемых автомобилях.
    //</summary>
    [Fact]
    public void TopFiveCars()
    {
        var foundedCars = _testDataProvider.RentedCars
            .GroupBy(r => r.Car)
            .OrderByDescending(g => g.Count())
            .Take(5)
            .Select(g => g.Key)
            .ToList();
        Assert.Equal(_testDataProvider.Cars[3], foundedCars[0]);
        Assert.Equal(_testDataProvider.Cars[4], foundedCars[1]);
        Assert.Equal(_testDataProvider.Cars[0], foundedCars[2]);
        Assert.Equal(_testDataProvider.Cars[5], foundedCars[3]);
        Assert.Equal(_testDataProvider.Cars[1], foundedCars[4]);
    }

    //<summary>
    //Проверка возврата количества аренд для конкретного автомобиля.
    //</summary>
    [Fact]
    public void NumbersOfRental()
    {
        var carsRentalCounts = _testDataProvider.RentedCars
            .GroupBy(r => r.Car.Id)
            .Select(g => new {Car = g.Key, CarNumber = g.First().Car.Number, Count = g.Count()})
            .OrderBy(x => x.CarNumber)
            .ToList();
        Assert.Equal(4, carsRentalCounts[0].Count);
        Assert.Equal(1, carsRentalCounts[1].Count);
        Assert.Equal(1, carsRentalCounts[2].Count);
        Assert.Equal(7, carsRentalCounts[3].Count);
        Assert.Equal(5, carsRentalCounts[4].Count);
        Assert.Equal(3, carsRentalCounts[5].Count);
    }

    /// <summary>
    ///Проверка возврата пункта проката с максимальным числом аренд.
    /// </summary>
    [Fact]
    public void RentalPlaceWithMostRents()
    {
        var foundedRentalPlace = _testDataProvider.RentedCars
            .GroupBy(r => r.RentalPlace)
            .OrderByDescending(g => g.Count())
            .ThenBy(g => g.Key!.Name)
            .Select(g => g.Key)
            .Take(1)
            .ToList();
        Assert.Equal(_testDataProvider.RentalPlaces[2], foundedRentalPlace[0]);
    }

}