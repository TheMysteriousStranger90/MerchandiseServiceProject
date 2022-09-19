using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using MerchandiseServiceHttpClients.Interfaces;
using MerchandiseServiceModels;

namespace MerchandiseServiceHttpClients
{
    public class MerchandiseHttpClient : IMerchandiseHttpClient
    {
        private readonly HttpClient _httpClient;

        public MerchandiseHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GetMerchResponse> GetMerch(long employeeId, string itemName, CancellationToken token)
        {
            //throw new System.NotImplementedException();
            
            using var response = await _httpClient.GetAsync("v1/api/merch", token);
            return await response.Content.ReadFromJsonAsync<GetMerchResponse>(cancellationToken: token);
        }

        public async Task<GetOrderStateResponse> GetMerchOrderState(long id, CancellationToken token)
        {
           // throw new System.NotImplementedException();
           
           using var response = await _httpClient.GetAsync("v1/api/merch/check", token);
           return await response.Content.ReadFromJsonAsync<GetOrderStateResponse>(cancellationToken: token);
        }
    }
}