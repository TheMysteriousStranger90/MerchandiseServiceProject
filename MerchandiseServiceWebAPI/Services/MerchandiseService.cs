using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MerchandiseServiceModels;
using MerchandiseServiceWebAPI.Services.Interfaces;

namespace MerchandiseServiceWebAPI.Services
{
    public class MerchandiseService : IMerchandiseService
    {
        private readonly GetOrderStateResponse _orderStateResponse = new GetOrderStateResponse(OrderStatus.Other);

        public Task<GetMerchResponse> GetMerchandise(GetMerchRequest request, CancellationToken _)
        {
            var response = new GetMerchResponse(new MerchOrder(1,
                new List<MerchItem>()
                    { new MerchItem(request.MerchItem.Id, request.MerchItem.ItemName, request.MerchItem.Quantity) }));
            return Task.FromResult(response);
        }

        public Task<GetOrderStateResponse> GetMerchandiseOrderState(GetOrderStateRequest request, CancellationToken _)
        {
            return Task.FromResult(_orderStateResponse);
        }
    }
}