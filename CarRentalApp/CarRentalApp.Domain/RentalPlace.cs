namespace CarRentalApp.Domain;

public class RentalPlace
{
    /// <summary>
    /// ID
    /// </summary>
    public required int Id { set; get; }

    /// <summary>
    /// Названия прокатного пункта
    /// </summary>
    public required string Name { set; get; }

	/// <summary>
	/// Адрес
	/// </summary>
	public required string Address { set; get; }

}

