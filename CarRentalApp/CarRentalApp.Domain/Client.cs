namespace CarRentalApp.Domain;

public class Client
{
    // <summary>
    // ID клиента
    // </summary>
    public required int id { set; get; }

    // <summary>
    // Номер паспорта 
    // </summary>
    public required int PassportNumber { set; get; }

    // <summary>
    // ФИО
    // </summary>
    public required string FullName { set; get; }

    // <summary>
    // Дата рождения 
    // </summary>
    public required DateOnly BirthDate { set; get; }

}

