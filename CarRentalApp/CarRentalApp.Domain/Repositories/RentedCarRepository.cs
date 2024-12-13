namespace CarRentalApp.Domain.Repositories;

/// <summary>
/// Репозиторий для работы с сущностями RentedCar.
/// Реализует интерфейс IRepository для управления коллекцией арендованных машин.
/// </summary>
public class RentedCarRepository : IRepository<RentedCar>
{
    private readonly List<RentedCar> _rentedCars = [];
    private int _id = 1;

    /// <summary>
    /// Получает список всех арендованных машин.
    /// </summary>
    /// <returns>Возвращает список всех арендованных машин</returns>
    public IEnumerable<RentedCar> GetAll() => _rentedCars;

    /// <summary>
    /// Возвращает арендованную машину по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор арендованной машины</param>
    /// <returns>Возвращает арендованную машину с заданным идентификатором</returns>
    public RentedCar? Get(int id) => _rentedCars.Find(c => c.Id == id);

    /// <summary>
    /// Добавляет новую арендованную машину в репозиторий.
    /// </summary>
    /// <param name="obj">Машина, которую нужно добавить.</param>
    /// <returns>Возвращает добавленную машину</returns>
    public RentedCar Post(RentedCar obj)
    {
        obj.Id = _id++;
        _rentedCars.Add(obj);
        return obj;
    }

    /// <summary>
    /// Обновляет информацию об арендованной машине по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор машины</param>
    /// <param name="obj">Объект с новыми данными</param>
    /// <returns>Возвращает true, если информация обновилась, иначе false</returns>
    public bool Put(int id, RentedCar obj)
    {
        var oldValue = Get(id);
        if (oldValue == null)
        {
            return false;
        }

        oldValue.RentalPeriod = obj.RentalPeriod;
        oldValue.RentalPlace = obj.RentalPlace;
        oldValue.ReturnRentalPlace = oldValue.ReturnRentalPlace;
        oldValue.Client = obj.Client;
        oldValue.Car = obj.Car;
        oldValue.IssueTime = obj.IssueTime;
        return true;
    }

    /// <summary>
    /// Удаляет арендованную машину по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор машины</param>
    /// <returns>Возвращает true, если машина удалена, иначе false.</returns>
    public bool Delete(int id)
    {
        var value = Get(id);
        if (value == null)
        {
            return false;
        }

        _rentedCars.Remove(value);
        return true;
    }
}
