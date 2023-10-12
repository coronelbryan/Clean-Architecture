namespace Core.Services;

public interface ICache
{
    void Cache(string data, DateTime expiredOn);
}