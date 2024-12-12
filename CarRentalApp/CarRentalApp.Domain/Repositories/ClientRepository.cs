namespace CarRentalApp.Domain.Repositories;

/// <summary>
/// Репозиторий для работы с сущностями Client.
/// Реализует интерфейс IRepository для управления коллекцией клиентов.
/// </summary>
public class ClientRepository : IRepository<Client>
{
    private readonly List<Client> _clients = [];
    private int _id = 1;

    /// <summary>
    /// Получает список всех клиентов.
    /// </summary>
    /// <returns>Возвращает список всех клиентов</returns>
    public IEnumerable<Client> GetAll() => _clients;

    /// <summary>
    /// Возвращает клиента по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор клиента</param>
    /// <returns>Возвращает клиента с заданным идентификаторм</returns>
    public Client? Get(int id) => _clients.Find(c => c.Id == id);

    /// <summary>
    /// Добавляет нового клиента в репозиторий.
    /// </summary>
    /// <param name="obj">Клиент, которого нужно добавить.</param>
    /// <returns>Возвращает добавленного клиента</returns>
    public Client Post(Client obj)
    {
        obj.Id = _id++;
        _clients.Add(obj);
        return obj;
    }

    /// <summary>
    /// Обновляет информацию о клиенте по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор клиента</param>
    /// <param name="obj">Объект с новыми данными</param>
    /// <returns>Возвращает true, если информация обновилась, иначе false</returns>
    public bool Put(int id, Client obj)
    {
        var oldValue = Get(id);
        if (oldValue == null)
        {
            return false;
        }

        oldValue.PassportNumber = obj.PassportNumber;
        oldValue.FullName = obj.FullName;
        oldValue.BirthDate = obj.BirthDate;
        return true;
    }

    /// <summary>
    /// Удаляет клиента по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор клиента</param>
    /// <returns>Возвращает true, если машина удалена, иначе false.</returns>
    public bool Delete(int id)
    {
        var value = Get(id);
        if (value == null)
        {
            return false;
        }

        _clients.Remove(value);
        return true;
    }
}
