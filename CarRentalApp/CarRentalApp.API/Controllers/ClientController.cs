using CarRentalApp.API.DTO;
using CarRentalApp.Domain;
using CarRentalApp.Domain.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalApp.API.Controllers;

/// <summary>
/// Контролер по управлению клиентами.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class ClientController(IRepository<Client> repository, IMapper mapper) : ControllerBase
{
    /// <summary>
    /// Возвращает список всех клиентов.
    /// </summary>
    /// <returns>Список всех клиентов и http status</returns>
    [HttpGet]
    public ActionResult<IEnumerable<ClientDto>> GetAll()
    {
        return Ok(repository.GetAll().Select(mapper.Map<Client>));
    }

    /// <summary>
    /// Возвращает Dto клиента по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор клиента</param>
    /// <returns>Возвращает клиента с заданным идентификатором.</returns>
    [HttpGet("{id}")]
    public ActionResult<ClientDto> Get(int id)
    {
        var client = repository.Get(id);

        if (client == null)
            return NotFound();

        return Ok();
    }
    /// <summary>
    /// Добавляет нового клиента в репозиторий.
    /// </summary>
    /// <param name="obj">Клиент, которого нужно добавить.</param>
    /// <returns>Возвращает Dto добавленного клиента или null, при ошибке</returns>
    [HttpPost]
    public ActionResult<ClientDto> Post([FromBody] ClientDto obj)
    {
        var client = mapper.Map<Client>(obj);
        return mapper.Map<ClientDto>(repository.Post(client));
    }


    /// <summary>
    /// Обновляет информацию о клиенте по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор клиента</param>
    /// <param name="obj">Dto объекта с новыми данными</param>
    /// <returns>Возвращает true, если информация обновилась, иначе false</returns>
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] ClientDto obj)
    {
        var client = mapper.Map<Client>(obj);
        repository.Put(id, client);
        return Ok();
    }

    /// <summary>
    /// Удаляет клиента по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор клиента</param>
    /// <returns>Возвращает true, если клиент удален, иначе false.</returns>
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        repository.Delete(id);
        return Ok();
    }
}
