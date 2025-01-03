﻿namespace CarRentalApp.Domain.Repositories;

public interface IRepository<T>
{
    /// <summary>
    /// Возвращает список всех объектов
    /// </summary>
    /// <returns>Список всех объектов</returns>
    public IEnumerable<T> GetAll();

    /// <summary>
    /// Возвращает объект по указанному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор объекта</param>
    /// <returns>Найденный объект, или null</returns>
    public T? Get(int id);

    /// <summary>
    /// Добавляет новый объект
    /// </summary>
    /// <param name="obj">Новый объект</param>
    public T Post(T obj);

    /// <summary>
    /// Заменяет объект, соответствующий идентификатору, на новый
    /// </summary>
    /// <param name="obj">Новый объект</param>
    /// <param name="id">Идентификатор объекта</param>
    /// <returns>true, если замена прошла успешно, иначе false</returns>
    public bool Put(int id, T obj);

    /// <summary>
    /// Удаляет объект, соответствующий идентификатору
    /// </summary>
    /// <param name="id">Идентификатор объекта</param>
    /// <returns>true, если удаление прошло успешно, иначе false</returns>
    public bool Delete(int id);

}