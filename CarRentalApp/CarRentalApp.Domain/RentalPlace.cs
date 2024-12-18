using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CarRentalApp.Domain;

[Table("RentalPlace")]
public class RentalPlace
{
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    [Column("id")]
    public required int Id { set; get; }

    /// <summary>
    /// Названия прокатного пункта
    /// </summary>
    [Column("name")]
    public required string Name { set; get; }

    /// <summary>
    /// Адрес
    /// </summary>
    [Column("address")]
    public required string Address { set; get; }

}

