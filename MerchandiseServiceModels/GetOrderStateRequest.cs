namespace MerchandiseServiceModels
{
    public class GetOrderStateRequest
    {
        public MerchOrder Order { get; }
        
        public GetOrderStateRequest(MerchOrder order)
        {
            Order = order;
        }
    }
}