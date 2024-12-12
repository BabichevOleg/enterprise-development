namespace CarRentalApp.API.DTO;

/// <summary>
/// Класс, предоставляющий информацио об объекте Car для передачи данных.
/// </summary>
public class CarDTO
{
    /// <summary>
    /// Номер машины 
    /// </summary>
    public required string Number { set; get; }

    /// <summary>
    /// Модель машины 
    /// </summary>
    public required string Model { set; get; }

    /// <summary>
    /// Цвет машины 
    /// </summary>
    public required string Color { set; get; }
}
