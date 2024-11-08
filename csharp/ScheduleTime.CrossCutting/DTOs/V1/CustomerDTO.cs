namespace ScheduleTime.CrossCutting.DTOs.V1
{
    public record CustomerDTO
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string FullName { get; init; }
        public string Email { get; init; }
        public string Phone { get; init; }

        private CustomerDTO()
        {
            if (FirstName is null) throw new ArgumentNullException(nameof(FirstName));
            if (LastName is null) throw new ArgumentNullException(nameof(LastName));
            if (FullName is null) throw new ArgumentNullException(nameof(FullName));
            if (Email is null) throw new ArgumentNullException(nameof(Email));
            if (Phone is null) throw new ArgumentNullException(nameof(Phone));
        }

        public CustomerDTO(string firstName, string lastName, string fullName, string email, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            Email = email;
            Phone = phone;
        }
    }
}
