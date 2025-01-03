﻿namespace CarRentalApp.Domain.Repositories;

/// <summary>
/// Репозиторий для работы с сущностями RentalPlace.
/// Реализует интерфейс IRepository для управления коллекцией прокатных пунктов.
/// </summary>
public class RentalPlaceRepository(CarRentalAppDbContext context) : IRepository<RentalPlace>
{
    /// <summary>
    /// Получает список всех прокатных пунктов.
    /// </summary>
    /// <returns>Возвращает список всех прокатных пунктов</returns>
    public IEnumerable<RentalPlace> GetAll() => context.RentalPlaces.ToList();

    /// <summary>
    /// Возвращает прокатный пункт по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор прокатного пункта</param>
    /// <returns>Возвращает прокатный пункт с заданным идентификатором</returns>
    public RentalPlace? Get(int id) => context.RentalPlaces.FirstOrDefault(r => r.Id == id);

    /// <summary>
    /// Добавляет новый прокатный пункт в репозиторий.
    /// </summary>
    /// <param name="obj">Прокатный пункт, который нужно добавить.</param>
    /// <returns>Возвращает добавленный прокатный пункт</returns>
    public RentalPlace Post(RentalPlace obj)
    {
        context.Add(obj);
        context.SaveChanges();
        return obj;
    }

    /// <summary>
    /// Обновляет информацию о прокатном пункте по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор прокатного пункта</param>
    /// <param name="obj">Объект с новыми данными</param>
    /// <returns>Возвращает true, если информация обновилась, иначе false</returns>
    public bool Put(int id, RentalPlace obj)
    {
        var oldValue = Get(id);
        if (oldValue == null)
        {
            return false;
        }

        oldValue.Name = obj.Name;
        oldValue.Address = obj.Address;
        context.SaveChanges();
        return true;
    }

    /// <summary>
    /// Удаляет прокатный пункт по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор прокатного пункт</param>
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
