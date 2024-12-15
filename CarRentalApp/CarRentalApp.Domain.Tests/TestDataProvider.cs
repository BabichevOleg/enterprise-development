namespace CarRentalApp.Domain.Tests;

public class TestDataProvider
{
    public List<Car> Cars =
    [
        new() { Id = 1, Number = "Number 1", Model = "Model 1", Color = "Color 1"},
        new() { Id = 2, Number = "Number 2", Model = "Model 2", Color = "Color 2"},
        new() { Id = 3, Number = "Number 3", Model = "Model 3", Color = "Color 3"},
        new() { Id = 4, Number = "Number 4", Model = "Model 4", Color = "Color 4"},
        new() { Id = 5, Number = "Number 5", Model = "Model 5", Color = "Color 5"},
        new() { Id = 6, Number = "Number 6", Model = "Model 6", Color = "Color 6"}
    ];

    public List<RentalPlace> RentalPlaces =
    [
        new() { Id = 1, Name = "Name 1", Address = "Address 1"},
        new() { Id = 2, Name = "Name 2", Address = "Address 2"},
        new() { Id = 3, Name = "Name 3", Address = "Address 3"},
        new() { Id = 4, Name = "Name 4", Address = "Address 4"},
        new() { Id = 5, Name = "Name 5", Address = "Address 5"},
        new() { Id = 6, Name = "Name 6", Address = "Address 6"}
    ];

    public List<Client> Clients =
    [
        new() { Id = 1, PassportNumber = 1111111, FullName = "Full name 1", BirthDate =  new DateOnly(1991, 1, 1)},
        new() { Id = 2, PassportNumber = 2222222, FullName = "Full name 2", BirthDate =  new DateOnly(1992, 2, 2)},
        new() { Id = 3, PassportNumber = 3333333, FullName = "Full name 3", BirthDate =  new DateOnly(1993, 3, 3)},
        new() { Id = 4, PassportNumber = 4444444, FullName = "Full name 4", BirthDate =  new DateOnly(1994, 4, 4)},
        new() { Id = 5, PassportNumber = 5555555, FullName = "Full name 5", BirthDate =  new DateOnly(1995, 5, 5)},
        new() { Id = 6, PassportNumber = 6666666, FullName = "Full name 6", BirthDate =  new DateOnly(1996, 6, 6)},
    ];


    public List<RentedCar> RentedCars;

    public TestDataProvider()
    {
        RentedCars =
        [
            new RentedCar
            {
                Id = 1,
                Car = Cars[1],
                RentalPlace = RentalPlaces[2],
                Client = Clients[3],
                IssueTime = DateTime.Now.AddDays(-6),
                RentalPeriod = TimeSpan.FromDays(2),
                ReturnTime = DateTime.Now.AddDays(-4),
                ReturnRentalPlace = RentalPlaces[4]
            },
            new RentedCar
            {
                Id = 2,
                Car = Cars[3],
                RentalPlace = RentalPlaces[4],
                Client = Clients[4],
                IssueTime = DateTime.Now.AddDays(-4),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(-3),
                ReturnRentalPlace = RentalPlaces[5]
            },
            new RentedCar
            {
                Id = 3,
                Car = Cars[3],
                RentalPlace = RentalPlaces[4],
                Client = Clients[5],
                IssueTime = DateTime.Now.AddDays(-1),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(0),
                ReturnRentalPlace = RentalPlaces[0]
            },
            new RentedCar
            {
                Id = 4,
                Car = Cars[4],
                RentalPlace = RentalPlaces[5],
                Client = Clients[3],
                IssueTime = DateTime.Now.AddDays(-5),
                RentalPeriod = TimeSpan.FromDays(4),
                ReturnTime = DateTime.Now.AddDays(-1),
                ReturnRentalPlace = RentalPlaces[0]
            },
            new RentedCar
            {
                Id = 5,
                Car = Cars[0],
                RentalPlace = RentalPlaces[1],
                Client = Clients[2],
                IssueTime = DateTime.Now.AddDays(-6),
                RentalPeriod = TimeSpan.FromDays(3),
                ReturnTime = DateTime.Now.AddDays(-3),
                ReturnRentalPlace = RentalPlaces[3]
            },
            new RentedCar
            {
                Id = 6,
                Car = Cars[5],
                RentalPlace = RentalPlaces[2],
                Client = Clients[1],
                IssueTime = DateTime.Now.AddDays(-3),
                RentalPeriod = TimeSpan.FromDays(2),
                ReturnTime = DateTime.Now.AddDays(-1),
                ReturnRentalPlace = RentalPlaces[1]
            },
            new RentedCar
            {
                Id = 7,
                Car = Cars[3],
                RentalPlace = RentalPlaces[0],
                Client = Clients[0],
                IssueTime = DateTime.Now.AddDays(-3),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(-2),
                ReturnRentalPlace = RentalPlaces[4]
            },
            new RentedCar
            {
                Id = 8,
                Car = Cars[5],
                RentalPlace = RentalPlaces[1],
                Client = Clients[4],
                IssueTime = DateTime.Now.AddDays(-6),
                RentalPeriod = TimeSpan.FromDays(5),
                ReturnTime = DateTime.Now.AddDays(-1),
                ReturnRentalPlace = RentalPlaces[2]
            },
            new RentedCar
            {
                Id = 9,
                Car = Cars[0],
                RentalPlace = RentalPlaces[4],
                Client = Clients[1],
                IssueTime = DateTime.Now.AddDays(-5),
                RentalPeriod = TimeSpan.FromDays(6),
                ReturnTime = null,
                ReturnRentalPlace = null
            },
            new RentedCar
            {
                Id = 10,
                Car = Cars[4],
                RentalPlace = RentalPlaces[4],
                Client = Clients[2],
                IssueTime = DateTime.Now.AddDays(-3),
                RentalPeriod = TimeSpan.FromDays(4),
                ReturnTime = null,
                ReturnRentalPlace = null
            },
            new RentedCar
            {
                Id = 11,
                Car = Cars[3],
                RentalPlace = RentalPlaces[3],
                Client = Clients[4],
                IssueTime = DateTime.Now.AddDays(-5),
                RentalPeriod = TimeSpan.FromDays(8),
                ReturnTime = null,
                ReturnRentalPlace = null
            },
            new RentedCar
            { Id = 12,
                Car = Cars[3],
                RentalPlace = RentalPlaces[0],
                Client = Clients[1],
                IssueTime = DateTime.Now.AddDays(-6),
                RentalPeriod = TimeSpan.FromDays(5),
                ReturnTime = DateTime.Now.AddDays(-1),
                ReturnRentalPlace = RentalPlaces[1]
            },
            new RentedCar
            {
                Id = 13,
                Car = Cars[0],
                RentalPlace = RentalPlaces[3],
                Client = Clients[3],
                IssueTime = DateTime.Now.AddDays(-2),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(-1),
                ReturnRentalPlace = RentalPlaces[0]
            },
            new RentedCar
            { Id = 14,
                Car = Cars[4],
                RentalPlace = RentalPlaces[2],
                Client = Clients[0],
                IssueTime = DateTime.Now.AddDays(-4),
                RentalPeriod = TimeSpan.FromDays(2),
                ReturnTime = DateTime.Now.AddDays(-2),
                ReturnRentalPlace = RentalPlaces[5]
            },
            new RentedCar
            {
                Id = 15,
                Car = Cars[3],
                RentalPlace = RentalPlaces[0],
                Client = Clients[1],
                IssueTime = DateTime.Now.AddDays(-5),
                RentalPeriod = TimeSpan.FromDays(5),
                ReturnTime = DateTime.Now.AddDays(0),
                ReturnRentalPlace = RentalPlaces[2]
            },
            new RentedCar
            {
                Id = 16,
                Car = Cars[4],
                RentalPlace = RentalPlaces[5],
                Client = Clients[5],
                IssueTime = DateTime.Now.AddDays(-3),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(-2),
                ReturnRentalPlace = RentalPlaces[5]
            },
            new RentedCar
            {
                Id = 17,
                Car = Cars[2],
                RentalPlace = RentalPlaces[1],
                Client = Clients[2],
                IssueTime = DateTime.Now.AddDays(-1),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(0),
                ReturnRentalPlace = RentalPlaces[0]
            },
            new RentedCar
            {
                Id = 18,
                Car = Cars[5],
                RentalPlace = RentalPlaces[2],
                Client = Clients[0],
                IssueTime = DateTime.Now.AddDays(-6),
                RentalPeriod = TimeSpan.FromDays(4),
                ReturnTime = DateTime.Now.AddDays(-2),
                ReturnRentalPlace = RentalPlaces[2]
            },
            new RentedCar
            {
                Id = 19,
                Car = Cars[0],
                RentalPlace = RentalPlaces[5],
                Client = Clients[5],
                IssueTime = DateTime.Now.AddDays(-3),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(-2),
                ReturnRentalPlace = RentalPlaces[5]
            },
            new RentedCar
            {
                Id = 20,
                Car = Cars[4],
                RentalPlace = RentalPlaces[0],
                Client = Clients[3],
                IssueTime = DateTime.Now.AddDays(-2),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(-1),
                ReturnRentalPlace = RentalPlaces[1]
            },
            new RentedCar
            {
                Id = 21,
                Car = Cars[3],
                RentalPlace = RentalPlaces[2],
                Client = Clients[5],
                IssueTime = DateTime.Now.AddDays(-2),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(-1),
                ReturnRentalPlace = RentalPlaces[1]
            }
        ];
    }
}
       
