using Core.Entities;
using Core.Repositories;

namespace Core.Services;

public interface IEntityTypeService
{
    EntityType GetById(int id);
    IEnumerable<EntityType> GetEntityTypes();
    EntityType Add(EntityType entityType);
    EntityType Update(int id, EntityType entityType);
    void Delete(int id);
}

public class EntityTypeService : IEntityTypeService
{
    private readonly IEntityTypeRepository entityTypeRepository;

    public EntityTypeService(IEntityTypeRepository entityTypeRepository)
    {
        this.entityTypeRepository = entityTypeRepository;
    }

    public EntityType Add(EntityType entityType)
    {
        this.entityTypeRepository.Add(entityType);
        return entityType;
    }

    public void Delete(int id)
    {
        this.entityTypeRepository.Delete(id);
    }

    public EntityType GetById(int id)
    {
        return this.entityTypeRepository.GetById(id);
    }

    public IEnumerable<EntityType> GetEntityTypes()
    {
        return this.entityTypeRepository.GetEntityTypes();
    }

    public EntityType Update(int id, EntityType entityType)
    {
        return this.entityTypeRepository.Update(id, entityType);
    }
}