using System.Threading;
using System.Threading.Tasks;
using MerchandiseServiceModels;
using Microsoft.AspNetCore.Mvc;

namespace MerchandiseServiceHttpClients.Interfaces
{
    public interface IMerchandiseHttpClient
    {
        [HttpGet("{id:long}/{itemName}")]
        Task<GetMerchResponse> GetMerch([FromRoute] long employeeId, [FromRoute] string itemName,
            CancellationToken token);

        [HttpGet]
        Task<GetOrderStateResponse> GetMerchOrderState([FromQuery] long id, CancellationToken token);
    }
}