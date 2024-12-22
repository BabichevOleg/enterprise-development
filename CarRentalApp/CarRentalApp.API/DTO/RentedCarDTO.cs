using CarRentalApp.Domain;

namespace CarRentalApp.API.Dto;

/// <summary>
/// Класс, предоставляющий информацию об объекте RentedCar для передачи данных.
/// </summary>
public class RentedCarDto
{
    /// <summary>
    /// Выданный автомобиль 
    /// </summary>
    public required Car Car { set; get; }

    /// <summary>
    /// Пункт проката
    /// </summary>
    public required RentalPlace RentalPlace { set; get; }

    /// <summary>
    /// Клиент получивший машину
    /// </summary>
    public required Client Client { set; get; }

    /// <summary>
    /// Время выдачи
    /// </summary>
    public required DateTime IssueTime { set; get; }

    /// <summary>
    /// Срок аренды
    /// </summary>
    public TimeSpan? RentalPeriod { set; get; }

    /// <summary>
    /// Время возврата
    /// </summary>
    public DateTime? ReturnTime { set; get; }

    /// <summary>
    /// Пункт, в который вернули автомобиль
    /// </summary>
    public RentalPlace? ReturnRentalPlace { set; get; }
}