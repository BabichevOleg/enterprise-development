namespace CarRentalApp.Domain.Repositories;

/// <summary>
/// Репозиторий для работы с сущностями Car.
/// Реализует интерфейс IRepository для управления коллекцией машин.
/// </summary>
public class CarRepository(CarRentalAppDbContext context) : IRepository<Car>
{
    /// <summary>
    /// Получает список всех машин.
    /// </summary>
    /// <returns>Возвращает список всех машин</returns>
    public IEnumerable<Car> GetAll() => context.Cars.ToList();

    /// <summary>
    /// Возвращает машину по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор машины</param>
    /// <returns>Возвращает машину с заданным идентификатором</returns>
    public Car? Get(int id) => context.Cars.FirstOrDefault(c => c.Id == id);

    /// <summary>
    /// Добавляет новую машину в репозиторий.
    /// </summary>
    /// <param name="obj">Машина, которую нужно добавить.</param>
    /// <returns>Возвращает добавленную машину</returns>
    public Car Post(Car obj)
    {
        context.Cars.Add(obj);
        context.SaveChanges();
        return obj;
    }

    /// <summary>
    /// Обновляет информацию о машине по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор машины</param>
    /// <param name="obj">Объект с новыми данными</param>
    /// <returns>Возвращает true, если информация обновилась, иначе false</returns>
    public bool Put(int id, Car obj)
    {
        var oldValue = Get(id);
        if (oldValue == null)
        {
            return false;
        }

        oldValue.Model = obj.Model;
        oldValue.Color = obj.Color;
        oldValue.Number = obj.Number;

        context.SaveChanges();

        return true;
    }

    /// <summary>
    /// Удаляет машину по заданному идентификатору.
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

        context.Remove(value);
        context.SaveChanges();
        return true;
    }
}
