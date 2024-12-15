using CarRentalApp.API.DTO;
using CarRentalApp.Domain;
using CarRentalApp.Domain.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
namespace CarRentalApp.API.Controllers;

/// <summary>
/// Контролер по управлению пунктами проката.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class RentalPlaceController(IRepository<RentalPlace> repository, IMapper mapper) : ControllerBase
{
    /// <summary>
    /// Возвращает список всех пунктов проката.
    /// </summary>
    /// <returns>Список всех машин и http status</returns>
    [HttpGet]
    public ActionResult<IEnumerable<RentalPlaceDto>> GetAll()
    {
        return Ok(repository.GetAll().Select(mapper.Map<RentalPlace>));
    }

    /// <summary>
    /// Возвращает Dto пункта проката по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор пункта проката</param>
    /// <returns>Возвращает пункт проката с заданным идентификатором</returns>
    [HttpGet("{id}")]
    public ActionResult<RentalPlaceDto> Get(int id)
    {
        var rentalPlace = repository.Get(id);

        if (rentalPlace == null)
            return NotFound();

        return Ok();
    }
    /// <summary>
    /// Добавляет новый пункт проката в репозиторий.
    /// </summary>
    /// <param name="obj">Пункт проката, который нужно добавить.</param>
    /// <returns>Возвращает Dto добавленного пункта проката или null, при ошибке</returns>
    [HttpPost]
    public ActionResult<RentalPlaceDto> Post([FromBody] RentalPlaceDto obj)
    {
        var rentalPlace = mapper.Map<RentalPlace>(obj);
        repository.Post(rentalPlace);
        return Ok();
    }


    /// <summary>
    /// Обновляет информацию о пункте проката по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор пункта проката</param>
    /// <param name="obj">Dto объекта с новыми данными</param>
    /// <returns>Возвращает true, если информация обновилась, иначе false</returns>
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] RentalPlaceDto obj)
    {
        var rentalPlace = mapper.Map<RentalPlace>(obj);
        repository.Put(id, rentalPlace);
        return Ok();
    }

    /// <summary>
    /// Удаляет пункт проката по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор пункта проката</param>
    /// <returns>Возвращает true, если пункт проката удален, иначе false.</returns>
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        repository.Delete(id);
        return Ok();
    }
}
