namespace CarRentalApp.Domain;

public class Car
{
    // <summary>
    // ID машины 
    // </summary>
    public required int Id { set; get; } 

    // <summary>
    // Номер машины 
    // </summary>
    public required string Number { set; get; }

    // <summary>
    // Модель машины 
    // </summary>
    public required string Model { set; get; }

    // <summary>
    // Цвет машины 
    // </summary>
    public required string Color { set; get; }
    
}

