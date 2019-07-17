namespace Domain.RegistrarOfficeAggregate.Student
{
    public class ContactDetails
    {
        public int ContactDetailsId { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int StudentAccountId { get; set; }
        //public StudentAccount Student { get; set; }
    }
}
