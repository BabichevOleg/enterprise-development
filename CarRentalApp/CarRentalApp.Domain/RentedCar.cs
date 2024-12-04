namespace CarRentalApp.Domain;

public class RentedCar
{
    // <summary>
    // ID аренды
    // </summary>
    public required int id { set; get; }

    // <summary>
    // Выданный автомобиль 
    // </summary>
    public required Car Car { set; get; }

    // <summary>
    // Пункт проката
    // </summary>
    public required RentalPlace RentalPlace { set; get; }

    // <summary>
    // Клиент получивший машину
    // </summary>
    public required Client Client { set; get; }

    // <summary>
    // Время выдачи
    // </summary>
    public required DateTime IssueTime { set; get; }

    // <summary>
    // Срок аренды
    // </summary>
    public TimeSpan? RentalPeriod { set; get; }

    // <summary>
    // Время возврата
    // </summary>
    public DateTime? ReturnTime { set; get; }

    // <summary>
    // Пункт, в который возвращают
    // </summary>
    public RentalPlace? ReturnRentalPlace { set; get; }


}

