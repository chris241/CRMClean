namespace CRM.Domain.Employee
{
    public class Employee : Entity, IAggregateRoot
    {
        public EmployeeId? Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? phoneNumber { get; set; }
        public string? Fonction { get; set; }

    }
}