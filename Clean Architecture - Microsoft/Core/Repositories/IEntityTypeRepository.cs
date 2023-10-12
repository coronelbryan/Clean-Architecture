using Core.Entities;

namespace Core.Repositories;

public interface IEntityTypeRepository
{
    EntityType GetById(int id);
    IEnumerable<EntityType> GetEntityTypes();
    void Add(EntityType entityType);
    EntityType Update(int id, EntityType entityType);
    void Delete(int id);
}