namespace MerchandiseServiceModels
{
    public class MerchItem
    {
        public long Id { get; }

        public string ItemName { get; }

        public int Quantity { get; }

        public MerchItem(long itemId, string _itemName, int quantity)
        {
            Id = itemId;
            ItemName = _itemName;
            Quantity = quantity;
        }
    }
}