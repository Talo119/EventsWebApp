
using System.Net.Http.Json;

namespace EventsWebApp.Services
{
    public class RepositoryGeneric : IRepositoryGeneric
    {
        private readonly HttpClient _httpClient;
        public RepositoryGeneric()
        {
            
        }
        public RepositoryGeneric(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Respuesta> Add<T>(string url, T data)
        {
            try
            {
                Respuesta respuesta = new Respuesta();
                var response = await _httpClient.PostAsJsonAsync<T>($"{Constants.BaseApiAdress}{url}", data);
                var content = response.Content.ReadFromJsonAsync<T>();
                var contentString = response.Content.ReadAsStringAsync().Result;

                respuesta.Status = response.IsSuccessStatusCode;
                respuesta.Message = response.StatusCode.ToString();
                respuesta.Detail = contentString;

                return respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Respuesta> Delete<T>(string url, int id)
        {
            try
            {
                
                Respuesta respuesta = new Respuesta();
                var response = await _httpClient.DeleteAsync($"{Constants.BaseApiAdress}{url}/{id}");
                respuesta.Status = response.IsSuccessStatusCode;
                respuesta.Message = response.RequestMessage.ToString();
                return respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T> Get<T>(string url)
        {
            try
            {
                
                Respuesta respuesta = new Respuesta();

                var response = await _httpClient.GetFromJsonAsync<T>($"{Constants.BaseApiAdress}{url}");


                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<T> Get<T>(string url, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Respuesta> Update<T>(string url, int id, T data)
        {
            try
            {
                Respuesta respuesta = new Respuesta();
                var response = await _httpClient.PutAsJsonAsync<T>($"{Constants.BaseApiAdress}{url}/{id}", data);
                var content = response.Content.ReadFromJsonAsync<T>();
                var contentString = response.Content.ReadAsStringAsync().Result;

                respuesta.Status = response.IsSuccessStatusCode;
                respuesta.Message = response.RequestMessage.ToString();
                respuesta.Detail = contentString;

                return respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
