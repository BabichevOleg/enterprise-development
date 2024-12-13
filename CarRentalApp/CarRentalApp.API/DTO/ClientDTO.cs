namespace CarRentalApp.API.DTO;

/// <summary>
/// Класс, предоставляющий информацио об объекте Cliebt для передачи данных.
/// </summary>
public class ClientDto
{
    /// <summary>
    /// номер паспорта 
    /// </summary>
    public required int PassportNumber { set; get; }

    /// <summary>
    /// ФИО
    /// </summary>
    public required string FullName { set; get; }

    /// <summary>
    /// Дата рождения 
    /// </summary>
    public required DateOnly BirthDate { set; get; }
}
