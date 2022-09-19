namespace MerchandiseServiceModels
{
    public class GetMerchRequest
    {
        public Employee Employee { get; }

        public MerchItem MerchItem { get; }

        public GetMerchRequest(Employee employee, MerchItem merchItem)
        {
            Employee = employee;
            MerchItem = merchItem;
        }
    }
}