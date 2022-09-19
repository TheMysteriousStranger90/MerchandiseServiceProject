using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MerchandiseServiceModels;
using MerchandiseServiceWebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MerchandiseServiceWebAPI.Controllers
{
    [ApiController]
    [Route("v1/api/merch")]
    [Produces("application/json")]
    public class MerchandiseController : ControllerBase
    {
        private readonly IMerchandiseService _merchService;
        private readonly IMediator _mediator;

        public MerchandiseController(IMerchandiseService merchService, IMediator mediator)
        {
            _merchService = merchService;
            _mediator = mediator;
        }
        
        [HttpGet]
        public async Task<ActionResult<GetOrderStateResponse>> GetMerchOrderState([FromQuery] long id ,
            CancellationToken token)
        { 
            var request = new GetOrderStateRequest( new MerchOrder(id, new List<MerchItem>()));

            var merch = await _merchService.GetMerchandiseOrderState(request, token);
            return merch;
        }
    }
}