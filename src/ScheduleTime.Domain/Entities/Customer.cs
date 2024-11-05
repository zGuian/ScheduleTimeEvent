namespace ScheduleTime.Domain.Entities
{
    public class Customer
    {
        public long Id { get; private set; }
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string FullName { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string Phone { get; private set; } = string.Empty;

        private Customer() { }

        public Customer(string firstName, string lastName, string fullName, string email, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            Email = email;
            Phone = phone;
        }

        public static class Factories
        {
            public static Customer CreateCustomer(Customer customer)
            {
                return new Customer(customer.FirstName, customer.LastName,
                    customer.FullName, customer.Email, customer.Phone);
            }
        }
    }
}
