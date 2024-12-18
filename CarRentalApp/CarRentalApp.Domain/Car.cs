using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalApp.Domain;

[Table("Car")]
public class Car
{
    /// <summary>
    /// ID машины 
    /// </summary>
    [Key]
    [Column("id")]
    public required int Id { set; get; }

    /// <summary>
    /// Номер машины 
    /// </summary>
    [Column("number")]
    public required string Number { set; get; }

    /// <summary>
    /// Модель машины 
    /// </summary>
    [Column("model")]
    public required string Model { set; get; }

    /// <summary>
    /// Цвет машины 
    /// </summary>
    [Column("color")]
    public required string Color { set; get; }
    
}

