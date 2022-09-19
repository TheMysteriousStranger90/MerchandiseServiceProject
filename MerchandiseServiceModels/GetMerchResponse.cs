namespace MerchandiseServiceModels
{
    public class GetMerchResponse
    {
        public MerchOrder Order { get; }

        public GetMerchResponse(MerchOrder order)
        {
            Order = order;
        }
    }
}