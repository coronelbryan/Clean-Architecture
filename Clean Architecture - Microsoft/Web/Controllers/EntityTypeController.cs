using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Template;

namespace Web.Controllers;

[ApiController]
[Route("api/entitytypes")]
public class EntityTypeController : ControllerBase
{
    private readonly IEntityTypeService entityTypeService;

    public EntityTypeController(IEntityTypeService entityTypeService)
    {
        this.entityTypeService = entityTypeService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var entityTypes = entityTypeService.GetEntityTypes();
        return Ok(entityTypes);
    }

    [HttpGet("{id}")]
    public ActionResult<EntityType> Get(int id)
    {
        var entityType = entityTypeService.GetById(id);
        return Ok(entityType);
    }

    [HttpPost]
    public ActionResult<EntityType> Post([FromBody] EntityType entityType)
    {
        entityTypeService.Add(entityType);
        return Created(nameof(Get), entityType);
    }

    [HttpPut("{id}")]
    public ActionResult<EntityType> Update(int id, [FromBody] EntityType entityType)
    {
        if (entityType is null)
        {
            return BadRequest();
        }

        if (id != entityType.Id)
        {
            return BadRequest();
        }

        entityTypeService.Update(id, entityType);
        return Ok(entityType);
    }

    [HttpDelete("{id}")]
    public NoContentResult Delete(int id)
    {
        entityTypeService.Delete(id);
        return NoContent();
    }
}