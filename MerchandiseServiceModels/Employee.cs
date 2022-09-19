namespace MerchandiseServiceModels
{
    public class Employee
    {
        public long Id { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public Employee(long id, string _firstName, string _lastName)
        {
            Id = id;
            FirstName = _firstName;
            LastName = _lastName;
        }
    }
}