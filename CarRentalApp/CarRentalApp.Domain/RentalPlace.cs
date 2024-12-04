namespace CarRentalApp.Domain;

public class RentalPlace
{
    // <summary>
    // ID
    // </summary>
    public required int id { set; get; }

    // <summary>
    // Название 
    // </summary>
    public required string Name { set; get; }

	// <summary>
	// Адрес
	// </summary>
	public required string Address { set; get; }

}

