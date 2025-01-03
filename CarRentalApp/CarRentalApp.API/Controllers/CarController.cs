﻿using CarRentalApp.API.Dto;
using CarRentalApp.Domain;
using CarRentalApp.Domain.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalApp.API.Controllers;

/// <summary>
/// Контролер по управлению машинами.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class CarController(IRepository<Car> repository, IMapper mapper) : ControllerBase
{
    /// <summary>
    /// Возвращает список всех машин.
    /// </summary>
    /// <returns>Список всех машин и http status</returns>
    [HttpGet]
    public ActionResult<IEnumerable<CarDto>> GetAll()
    {
        return Ok(repository.GetAll().Select(mapper.Map<Car>));
    }

    /// <summary>
    /// Возвращает Dto машины по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор машины</param>
    /// <returns>Возвращает машину с заданным идентификатором</returns>
    [HttpGet("{id}")]
    public ActionResult<CarDto> Get(int id)
    {
        var car = repository.Get(id);
        
        if(car == null)
            return NotFound();
        
        return Ok();
    }
    /// <summary>
    /// Добавляет новую машину в репозиторий.
    /// </summary>
    /// <param name="obj">Машина, которую нужно добавить.</param>
    /// <returns>Возвращает Dto добавленной машины или null, при ошибке</returns>
    [HttpPost]
    public ActionResult<CarDto> Post([FromBody] CarDto obj)
    {
        var car = mapper.Map<Car>(obj);
        return mapper.Map<CarDto>(repository.Post(car));
    }


    /// <summary>
    /// Обновляет информацию о машине по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор машины</param>
    /// <param name="obj">Dto объекта с новыми данными</param>
    /// <returns>Возвращает true, если информация обновилась, иначе false</returns>
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] CarDto obj)
    {
        var car = mapper.Map<Car>(obj);
        repository.Put(id, car);
        return Ok();
    }

    /// <summary>
    /// Удаляет машину по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор машины</param>
    /// <returns>Возвращает true, если машина удалена, иначе false.</returns>
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        repository.Delete(id);
        return Ok();
    }
}
