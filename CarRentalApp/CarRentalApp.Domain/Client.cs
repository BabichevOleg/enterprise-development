using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CarRentalApp.Domain;

[Table("Client")]
public class Client
{
    /// <summary>
    /// ID клиента
    /// </summary>
    [Key]
    [Column("id")]
    public required int Id { set; get; }

    /// <summary>
    /// Номер паспорта 
    /// </summary>
    [Column("passport_number")]
    public required int PassportNumber { set; get; }

    /// <summary>
    /// ФИО
    /// </summary>
    [Column("full_name")]
    public required string FullName { set; get; }

    /// <summary>
    /// Дата рождения 
    /// </summary>
    [Column("birth_date")]
    public required DateOnly BirthDate { set; get; }

}

