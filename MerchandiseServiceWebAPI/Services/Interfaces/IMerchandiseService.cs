using System.Threading;
using System.Threading.Tasks;
using MerchandiseServiceModels;

namespace MerchandiseServiceWebAPI.Services.Interfaces
{
    public interface IMerchandiseService
    {
        Task<GetMerchResponse> GetMerchandise(GetMerchRequest request, CancellationToken _);
        Task<GetOrderStateResponse> GetMerchandiseOrderState(GetOrderStateRequest request, CancellationToken _);
    }
}