using System.Net.Http.Json;
namespace Blazor_DI_Interface_Service.Client.BaseService
{
    public class BaseService : IBaseService
    {
        private readonly HttpClient _http;

        public BaseService(HttpClient http)
        {
            _http = http;
        }

        public async Task<int> GetTotalBaseAsync()
        {
            return await _http.GetFromJsonAsync<int>("api/Dados/TotalBaseDeDados");
        }
    }
}
