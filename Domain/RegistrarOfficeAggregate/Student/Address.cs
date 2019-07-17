namespace Domain.RegistrarOfficeAggregate.Student
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string Suffix { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }


    public class Province
    {
        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }

}

