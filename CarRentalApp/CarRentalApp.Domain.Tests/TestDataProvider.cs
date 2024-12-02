namespace CarRentalApp.Domain.Tests;

public class TestDataProvider
{
    public List<Cars> cars =
    [
        new Cars { ID = 1, Number = "Number 1", Model = "Model 1", Color = "Color 1"},
        new Cars { ID = 2, Number = "Number 2", Model = "Model 2", Color = "Color 2"},
        new Cars { ID = 3, Number = "Number 3", Model = "Model 3", Color = "Color 3"},
        new Cars { ID = 4, Number = "Number 4", Model = "Model 4", Color = "Color 4"},
        new Cars { ID = 5, Number = "Number 5", Model = "Model 5", Color = "Color 5"},
        new Cars { ID = 6, Number = "Number 6", Model = "Model 6", Color = "Color 6"}
    ];

    public List<RentalPlaces> rentalPlace =
    [
        new RentalPlaces { ID = 1, Name = "Name 1", Address = "Address 1"},
        new RentalPlaces { ID = 2, Name = "Name 2", Address = "Address 2"},
        new RentalPlaces { ID = 3, Name = "Name 3", Address = "Address 3"},
        new RentalPlaces { ID = 4, Name = "Name 4", Address = "Address 4"},
        new RentalPlaces { ID = 5, Name = "Name 5", Address = "Address 5"},
        new RentalPlaces { ID = 6, Name = "Name 6", Address = "Address 6"}
    ];

    public List<Clients> clients =
    [
        new Clients { ID = 1, PassportNumber = 1111111, FullName = "Full name 1", BirthDate =  new DateOnly(1991, 1, 1) },
        new Clients { ID = 2, PassportNumber = 2222222, FullName = "Full name 2", BirthDate =  new DateOnly(1992, 2, 2)},
        new Clients { ID = 3, PassportNumber = 3333333, FullName = "Full name 3", BirthDate =  new DateOnly(1993, 3, 3)},
        new Clients { ID = 4, PassportNumber = 4444444, FullName = "Full name 4", BirthDate =  new DateOnly(1994, 4, 4)},
        new Clients { ID = 5, PassportNumber = 5555555, FullName = "Full name 5", BirthDate =  new DateOnly(1995, 5, 5)},
        new Clients { ID = 6, PassportNumber = 6666666, FullName = "Full name 6", BirthDate =  new DateOnly(1996, 6, 6)},
    ];

    public List<RentedCars> rentedCars;

    public TestDataProvider()
    {
        rentedCars = new List<RentedCars> {
            new RentedCars
            {
                ID = 1,
                Car = cars[1],
                RentalPlace = rentalPlace[2],
                Client = clients[3],
                IssueTime = DateTime.Now.AddDays(-6),
                RentalPeriod = TimeSpan.FromDays(2),
                ReturnTime = DateTime.Now.AddDays(-4),
                ReturnRentalPlace = rentalPlace[4]
            },

            new RentedCars
            {
                ID = 2,
                Car = cars[3],
                RentalPlace = rentalPlace[4],
                Client = clients[4],
                IssueTime = DateTime.Now.AddDays(-4),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(-3),
                ReturnRentalPlace = rentalPlace[5]
            },

            new RentedCars
            {
                ID = 3,
                Car = cars[3],
                RentalPlace = rentalPlace[4],
                Client = clients[5],
                IssueTime = DateTime.Now.AddDays(-1),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(0),
                ReturnRentalPlace = rentalPlace[0]
            },

            new RentedCars
            {
                ID = 4,
                Car = cars[4],
                RentalPlace = rentalPlace[5],
                Client = clients[3],
                IssueTime = DateTime.Now.AddDays(-5),
                RentalPeriod = TimeSpan.FromDays(4),
                ReturnTime = DateTime.Now.AddDays(-1),
                ReturnRentalPlace = rentalPlace[0]
            },

            new RentedCars
            {
                ID = 5,
                Car = cars[0],
                RentalPlace = rentalPlace[1],
                Client = clients[2],
                IssueTime = DateTime.Now.AddDays(-6),
                RentalPeriod = TimeSpan.FromDays(3),
                ReturnTime = DateTime.Now.AddDays(-3),
                ReturnRentalPlace = rentalPlace[3]
            },

            new RentedCars
            {
                ID = 6,
                Car = cars[5],
                RentalPlace = rentalPlace[2],
                Client = clients[1],
                IssueTime = DateTime.Now.AddDays(-3),
                RentalPeriod = TimeSpan.FromDays(2),
                ReturnTime = DateTime.Now.AddDays(-1),
                ReturnRentalPlace = rentalPlace[1]
            },

            new RentedCars
            {
                ID = 7,
                Car = cars[3],
                RentalPlace = rentalPlace[0],
                Client = clients[0],
                IssueTime = DateTime.Now.AddDays(-3),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(-2),
                ReturnRentalPlace = rentalPlace[4]
            },

            new RentedCars
            {
                ID = 8,
                Car = cars[5],
                RentalPlace = rentalPlace[1],
                Client = clients[4],
                IssueTime = DateTime.Now.AddDays(-6),
                RentalPeriod = TimeSpan.FromDays(5),
                ReturnTime = DateTime.Now.AddDays(-1),
                ReturnRentalPlace = rentalPlace[2]
            },

            new RentedCars
            {
                ID = 9,
                Car = cars[0],
                RentalPlace = rentalPlace[4],
                Client = clients[1],
                IssueTime = DateTime.Now.AddDays(-5),
                RentalPeriod = TimeSpan.FromDays(6),
                ReturnTime = null,
                ReturnRentalPlace = null
            },

            new RentedCars
            {
                ID = 10,
                Car = cars[4],
                RentalPlace = rentalPlace[4],
                Client = clients[2],
                IssueTime = DateTime.Now.AddDays(-3),
                RentalPeriod = TimeSpan.FromDays(4),
                ReturnTime = null,
                ReturnRentalPlace = null
            },
            new RentedCars
            {
                ID = 11,
                Car = cars[3],
                RentalPlace = rentalPlace[3],
                Client = clients[4],
                IssueTime = DateTime.Now.AddDays(-5),
                RentalPeriod = TimeSpan.FromDays(8),
                ReturnTime = null,
                ReturnRentalPlace = null
            },

            new RentedCars
            { ID = 12,
                Car = cars[3],
                RentalPlace = rentalPlace[0],
                Client = clients[1],
                IssueTime = DateTime.Now.AddDays(-6),
                RentalPeriod = TimeSpan.FromDays(5),
                ReturnTime = DateTime.Now.AddDays(-1),
                ReturnRentalPlace = rentalPlace[1]
            },

            new RentedCars
            {
                ID = 13,
                Car = cars[0],
                RentalPlace = rentalPlace[3],
                Client = clients[3],
                IssueTime = DateTime.Now.AddDays(-2),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(-1),
                ReturnRentalPlace = rentalPlace[0]
            },

            new RentedCars
            { ID = 14,
                Car = cars[4],
                RentalPlace = rentalPlace[2],
                Client = clients[0],
                IssueTime = DateTime.Now.AddDays(-4),
                RentalPeriod = TimeSpan.FromDays(2),
                ReturnTime = DateTime.Now.AddDays(-2),
                ReturnRentalPlace = rentalPlace[5]
            },

            new RentedCars
            {
                ID = 15,
                Car = cars[3],
                RentalPlace = rentalPlace[0],
                Client = clients[1],
                IssueTime = DateTime.Now.AddDays(-5),
                RentalPeriod = TimeSpan.FromDays(5),
                ReturnTime = DateTime.Now.AddDays(0),
                ReturnRentalPlace = rentalPlace[2]
            },

            new RentedCars
            {
                ID = 16,
                Car = cars[4],
                RentalPlace = rentalPlace[5],
                Client = clients[5],
                IssueTime = DateTime.Now.AddDays(-3),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(-2),
                ReturnRentalPlace = rentalPlace[5]
            },

            new RentedCars
            {
                ID = 17,
                Car = cars[2],
                RentalPlace = rentalPlace[1],
                Client = clients[2],
                IssueTime = DateTime.Now.AddDays(-1),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(0),
                ReturnRentalPlace = rentalPlace[0]
            },

            new RentedCars
            {
                ID = 18,
                Car = cars[5],
                RentalPlace = rentalPlace[2],
                Client = clients[0],
                IssueTime = DateTime.Now.AddDays(-6),
                RentalPeriod = TimeSpan.FromDays(4),
                ReturnTime = DateTime.Now.AddDays(-2),
                ReturnRentalPlace = rentalPlace[2]
            },

            new RentedCars
            {
                ID = 19,
                Car = cars[0],
                RentalPlace = rentalPlace[5],
                Client = clients[5],
                IssueTime = DateTime.Now.AddDays(-3),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(-2),
                ReturnRentalPlace = rentalPlace[5]
            },

            new RentedCars
            {
                ID = 20,
                Car = cars[4],
                RentalPlace = rentalPlace[0],
                Client = clients[3],
                IssueTime = DateTime.Now.AddDays(-2),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(-1),
                ReturnRentalPlace = rentalPlace[1]
            },

            new RentedCars
            {
                ID = 21,
                Car = cars[3],
                RentalPlace = rentalPlace[2],
                Client = clients[5],
                IssueTime = DateTime.Now.AddDays(-2),
                RentalPeriod = TimeSpan.FromDays(1),
                ReturnTime = DateTime.Now.AddDays(-1),
                ReturnRentalPlace = rentalPlace[1]
            }
        };
    }
}
       
