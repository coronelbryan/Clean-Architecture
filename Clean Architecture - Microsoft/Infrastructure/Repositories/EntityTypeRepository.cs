using Core.Entities;
using Core.Repositories;
using Infrastructure.Datas;
using Microsoft.EntityFrameworkCore;

public class EntityTypeRepository : IEntityTypeRepository
{
    private readonly DatabaseContext dbContext;

    public EntityTypeRepository(DatabaseContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void Add(EntityType entityType)
    {
        dbContext.Add<EntityType>(entityType);
        dbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        var entityType = GetById(id);

        if (entityType is null)
        {
            // handle null does not exists
        }

        dbContext.Remove<EntityType>(entityType);
        dbContext.SaveChanges();
    }

    public EntityType GetById(int id)
    {
        return this.dbContext.Set<EntityType>()
            .AsNoTracking()
            .FirstOrDefault(e => e.Id == id);
    }

    public IEnumerable<EntityType> GetEntityTypes()
    {
        return this.dbContext.Set<EntityType>().ToList();
    }

    public EntityType Update(int id, EntityType entityType)
    {
        var entityTypeFromDb = GetById(id);

        if (entityTypeFromDb is null)
        {
            // handle does not exists
        }

        this.dbContext.Update<EntityType>(entityType);
        dbContext.SaveChanges();
        return entityType;
    }
}
