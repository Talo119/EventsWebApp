namespace EventsWebApp.Services
{
    public interface IRepositoryGeneric
    {
        Task<T> Get<T>(string url);
        Task<T> Get<T>(string url, int id);
        Task<Respuesta> Add<T>(string url, T data);
        Task<Respuesta> Update<T>(string url, int id, T data);
        Task<Respuesta> Delete<T>(string url, int id);
    }
}
