using System.Collections.Generic;

namespace MerchandiseServiceModels
{
    public class MerchOrder
    {
        public long Id { get; }
        public OrderStatus Status { get; }
        public List<MerchItem> MerchItems { get; }

        public MerchOrder(long id, List<MerchItem> items)
        {
            Id = id;
            MerchItems = items;
            Status = OrderStatus.New;
        }
    }
}