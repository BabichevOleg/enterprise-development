namespace CarRentalApp.Domain;

public class RentedCar
{
    // <summary>
    // ID аренды
    // </summary>
    public required int Id { set; get; }

    // <summary>
    // выданный автомобиль 
    // </summary>
    public required Car Car { set; get; }

    // <summary>
    // пункт проката
    // </summary>
    public required RentalPlace RentalPlace { set; get; }

    // <summary>
    // клиент получивший машину
    // </summary>
    public required Client Client { set; get; }

    // <summary>
    // время выдачи
    // </summary>
    public required DateTime IssueTime { set; get; }

    // <summary>
    // срок аренды
    // </summary>
    public TimeSpan? RentalPeriod { set; get; }

    // <summary>
    // время возврата
    // </summary>
    public DateTime? ReturnTime { set; get; }

    // <summary>
    // пункт, в который вернули автомобиль
    // </summary>
    public RentalPlace? ReturnRentalPlace { set; get; }


}

