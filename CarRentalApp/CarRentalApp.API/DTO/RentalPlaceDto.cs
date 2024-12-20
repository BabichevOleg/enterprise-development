namespace CarRentalApp.API.DTO;

/// <summary>
/// Класс, предоставляющий информацию об объекте RentalPlace для передачи данных.
/// </summary>
public class RentalPlaceDto
{
    /// <summary>
    /// Названия прокатного пункта
    /// </summary>
    public required string Name { set; get; }

    /// <summary>
    /// Адрес
    /// </summary>
    public required string Address { set; get; }
}
