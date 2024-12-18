using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CarRentalApp.Domain;

[Table("RentedCar")]
public class RentedCar
{
    /// <summary>
    /// ID аренды
    /// </summary>
    [Key]
    [Column("id")]
    public required int Id { set; get; }

    /// <summary>
    /// Выданный автомобиль 
    /// </summary>
    [Column("id")]
    public required Car Car { set; get; }

    /// <summary>
    /// Пункт проката
    /// </summary>
    [Column("rental_place")]
    public required RentalPlace RentalPlace { set; get; }

    /// <summary>
    /// Клиент получивший машину
    /// </summary>
    [Column("client")]
    public required Client Client { set; get; }

    /// <summary>
    /// Время выдачи
    /// </summary>
    [Column("issue_time")]
    public required DateTime IssueTime { set; get; }

    /// <summary>
    /// Срок аренды
    /// </summary>
    [Column("rental_period")]
    public TimeSpan? RentalPeriod { set; get; }

    /// <summary>
    /// Время возврата
    /// </summary>
    [Column("return_time")]
    public DateTime? ReturnTime { set; get; }

    /// <summary>
    /// Пункт, в который вернули автомобиль
    /// </summary>
    [Column("return_rental_place")]
    public RentalPlace? ReturnRentalPlace { set; get; }
}

