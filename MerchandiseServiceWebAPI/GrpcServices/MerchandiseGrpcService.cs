using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using MerchandiseServiceGrpc;
using MerchandiseServiceModels;
using MerchandiseServiceWebAPI.Services.Interfaces;
using Employee = MerchandiseServiceGrpc.Employee;

namespace MerchandiseServiceWebAPI.GrpcServices
{
    public class MerchandiseGrpcService: MerchandiseGrpc.MerchandiseGrpcBase
    {

        private readonly IMerchandiseService _merchandiseService;

        public MerchandiseGrpcService(IMerchandiseService merchandiseService)
        {
            _merchandiseService = merchandiseService;
        }

        public override async Task<GetMerchOrderStateResponseGrpc> GetMerchOrderState(GetMerchOrderStateRequestGrpc request, ServerCallContext context)
        {
            GetOrderStateRequest httpRequest = new GetOrderStateRequest(new MerchOrder
                (1, new List<MerchItem>() {new MerchItem(1,"T-shirt",2)}));
            
            var merchOrderState = await _merchandiseService.GetMerchandiseOrderState(httpRequest, context.CancellationToken);
            return new GetMerchOrderStateResponseGrpc()
            {
                State = merchOrderState.Status == OrderStatus.New? OrderState.New: 
                        merchOrderState.Status == OrderStatus.InProgress? OrderState.InProgress:
                        merchOrderState.Status == OrderStatus.GiveOut? OrderState.GiveOut:
                        OrderState.Other
            };
        }
        public override async Task<GetMerchResponseGrpc> GetMerch(GetMerchRequestGrpc request, ServerCallContext context)
        {
            var httpRequest = new GetMerchRequest(
                new Employee(request.Employee.Id, request.Employee.Name),
                new MerchItem(request.Merch.Name)
            );
            var merch = await _merchandiseService.GetMerchandise(httpRequest , context.CancellationToken);
            return new GetMerchResponseGrpc()
            {
                Merch = new MerchOrderUnit
                {
                    MerchOrderId = merch.Order.Id,
                    Merch = new MerchUnit
                    {
                        Name = merch.Order.MerchItems.First().ItemName
                    },
                    State = merch.Order.Status == OrderStatus.New? OrderState.New: 
                            merch.Order.Status == OrderStatus.InProgress? OrderState.InProgress:
                            merch.Order.Status == OrderStatus.GiveOut? OrderState.GiveOut:
                            OrderState.Other
                }
            };
        }
    }
}