namespace MerchandiseServiceModels
{
    public class GetOrderStateResponse
    {
        public OrderStatus Status { get; }

        public GetOrderStateResponse(OrderStatus status)
        {
            Status = status;
        }
    }
}