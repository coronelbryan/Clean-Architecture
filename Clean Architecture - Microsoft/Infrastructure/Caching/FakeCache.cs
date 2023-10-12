using Core.Services;

namespace Infrastructure.Cache;

public class FakeCache : ICache
{
    public void Cache(string data, DateTime expiredOn)
    {
        // fake implementation
    }
}
