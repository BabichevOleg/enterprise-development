namespace CarRentalApp.API.Dto;

/// <summary>
/// Класс, предоставляющий информацию об объекте Car для передачи данных.
/// </summary>
public class CarDto
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
