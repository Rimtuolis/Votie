namespace Votie.Server.Services
{
    public interface IDBOService
    {
        Task ExecuteAsync(string query);

        Task<List<T>> ReadListAsync<T>(string query);

        Task<T?> ReadItemAsync<T>(string query);
    }
}
