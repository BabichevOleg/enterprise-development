namespace CarRentalApp.Domain;

public class RentedCars
{
    // <summary>
    // ID аренды
    // </summary>
    public required int? ID { set; get; }

    // <summary>
    // Выданный автомобиль 
    // </summary>
    public required Cars? Car { set; get; }

    // <summary>
    // Пункт проката
    // </summary>
    public required RentalPlaces? RentalPlace { set; get; }

    // <summary>
    // Клиент получивший машину
    // </summary>
    public required Clients? Client { set; get; }

    // <summary>
    // Время выдачи
    // </summary>
    public required DateTime? IssueTime { set; get; }

    // <summary>
    // Срок аренды
    // </summary>
    public required TimeSpan? RentalPeriod { set; get; }

    // <summary>
    // Время возврата
    // </summary>
    public required DateTime? ReturnTime { set; get; }

    // <summary>
    // Пункт, в который возвращают
    // </summary>
    public required RentalPlaces? ReturnRentalPlace { set; get; }


}

