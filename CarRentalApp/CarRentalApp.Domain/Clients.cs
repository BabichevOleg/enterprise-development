namespace CarRentalApp.Domain;

public class Clients
{
    // <summary>
    // ID клиента
    // </summary>
    public required int? ID { set; get; }

    // <summary>
    // Номер паспорта 
    // </summary>
    public required int? PassportNumber { set; get; }

    // <summary>
    // ФИО
    // </summary>
    public required string? FullName { set; get; }

    // <summary>
    // Дата рождения 
    // </summary>
    public required DateOnly? BirthDate { set; get; }

}

