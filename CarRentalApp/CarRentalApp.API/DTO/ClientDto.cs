namespace CarRentalApp.API.Dto;

/// <summary>
/// Класс, предоставляющий информацию об объекте Client для передачи данных.
/// </summary>
public class ClientDto
{
    /// <summary>
    /// Номер паспорта 
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
