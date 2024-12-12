﻿using CarRentalApp.API.DTO;
using CarRentalApp.Domain;
using CarRentalApp.Domain.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace CarRentalApp.API.Controllers;

/// <summary>
/// Контролер по управлению машинами.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class RentedCarController(IRepository<RentedCar> repository, IMapper mapper) : ControllerBase
{
    /// <summary>
    /// Возвращает список всех арендованных машин.
    /// </summary>
    /// <returns>Список всех машин и http status</returns>
    [HttpGet]
    public ActionResult<IEnumerable<RentedCarDTO>> GetAll()
    {
        return Ok(repository.GetAll().Select(mapper.Map<RentedCar>));
    }

    /// <summary>
    /// Возвращает DTO арендованной машины по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор арендованной машины</param>
    /// <returns>Возвращает арендованную машину с заданным идентификаторм</returns>
    [HttpGet("{id}")]
    public ActionResult<RentedCarDTO> Get(int id)
    {
        var rentedCar = repository.Get(id);

        if (rentedCar == null)
            return NotFound();

        return Ok();
    }
    /// <summary>
    /// Добавляет новую арендованную машину в репозиторий.
    /// </summary>
    /// <param name="obj">Машина, которую нужно добавить.</param>
    /// <returns>Возвращает DTO добавленной арендованной машины или null, при ошибке</returns>
    [HttpPost]
    public ActionResult<RentedCarDTO> Post([FromBody] RentedCarDTO obj)
    {
        var rentedCar = mapper.Map<RentedCar>(obj);
        repository.Post(rentedCar);
        return Ok();
    }


    /// <summary>
    /// Обновляет информацию об арендованной машине по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор машины</param>
    /// <param name="obj">DTO объекта с новыми данными</param>
    /// <returns>Возвращает true, если информация обновилась, иначе false</returns>
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] RentedCarDTO obj)
    {
        var rentedCar = mapper.Map<RentedCar>(obj);
        repository.Put(id, rentedCar);
        return Ok();
    }

    /// <summary>
    /// Удаляет арендованную машину по заданному идентификатору.
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
